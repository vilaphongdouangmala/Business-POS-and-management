/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 17-Feb-22
 * Time: 7:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace termProject
{
	/// <summary>
	/// Description of FrmPOS.
	/// </summary>
	public partial class FrmPOS : Form
	{
        DataManager dm1 = new DataManager("localhost", "project", "root", "");    
        
        
        public FrmPOS()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//change datepicker format
			dtpShippingDate.Format = DateTimePickerFormat.Custom;
			dtpShippingDate.CustomFormat = "yyyy-MM-dd";
			dtpShippingDate.Enabled = false;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}//econ
        
        
        void FrmPOSLoad(object sender, EventArgs e)
		{
        	//load product info from database
			Global.products = Product.loadProductInfo();
		
			//set shipping default value
			cmbShipping.SelectedIndex = cmbShipping.FindStringExact("No");
			
        	
        	//create a product list in flowlayoutpanel
			showProductList();
			
			addAutoCompletes();
			
			updateOrderListView();
		}//ef
		
        private void addAutoCompletes()
        {
        	//add customer auto complete on customer name textbox
			addCustomerSuggestion();
			
        	//add AutoComplete functions
			productSearchAutoComplete();
			paymentTypeAutoComplete();
			shippingAutoComplete();
			discountCodeAutoComplete();
        }//ef
        

        private void updateOrderId()
        {
        	string sql = "SELECT orderId+1 FROM orders " +
        				 "ORDER BY orderId DESC";
			DataTable result = dm1.GetDataTable(sql);
			//if no order yet, then we make it to be order no. 1
			if (result.Rows.Count > 0)
			{
				string newOrderId = result.Rows[0][0].ToString();
				lblOrderId.Text = newOrderId;
			}
			else
			{
				lblOrderId.Text = "1";	
			}//end
			
        }//ef
        
        
        private void showProductList()
        {
        	//clear the panel first
        	flpProductList.Controls.Clear();
        	
        	//loop through each product in the global productList to create product list in the panel
        	foreach(Product product in Global.products)
        	{
        		addProductList(product.productName, product.productPrice.ToString("#,##0"), product.productName+".jpg", product.quantityInStock.ToString());
        	}//end loop
        }//ef
        
        
		private void addProductList(string productName, string price, string icon, string qtyInStock)
		{
			
			//create a new product card object
			ProductCard productCard = new ProductCard()
			{
				ProductTitle = productName,
			    ProductPrice = price + ".-",
			    //load into image folder and get icon
			    ProductPic = Image.FromFile("image/"+icon),
			    //set the qty to initially be 1 if the stock is enough using short-hand if
			    ProductQty = int.Parse(qtyInStock) > 0 ? "1" : "0"
			};
			
			//add product card to the flowLayoutPanel
			flpProductList.Controls.Add(productCard);
			
			
			//***This section is for Add to list and inc/dec qty buttons***
			//create an eventhandler on click to add the product to the list
			productCard.addToList += (ss, ee) =>
			{
				//create a temporary productcard as pc
				var pc = (ProductCard)ss;
				
				//find the productname
				Product orderedProduct	= searchProductByName(pc.ProductTitle);
				int orderedQuantity		= int.Parse(pc.ProductQty);
				
				//to fix user can click add to list even though the qty is not enough
				//get the order in listview
				orderDetails order = searchOrderByProduct(orderedProduct);
				//set default value as orderedQuantity for total for calculating
				int totalOrderedQty = orderedQuantity;
				int currentlyOrderedQty = 0;
				
				//if there is any existing error, then we check the current quantity ordered first
				if(order != null)
				{
					//get ordered qty in listview
					currentlyOrderedQty	+= order.quantity;
				
					//add it to ordered qty also to check with the stock
					totalOrderedQty += currentlyOrderedQty;
				}//end

				
				//check the stock
				if (totalOrderedQty <= orderedProduct.quantityInStock && orderedQuantity != 0)
				{
					//if enough then add product to the list
					if (orderedProduct != null)
					{
						//the add the new addtional qty ordered
						addOrder(orderedProduct, orderedQuantity);
					}
					//this else statement is done to prevent incorrect product name error
					else
					{
						return;
					}//end if else
				}
				//else show error message and change qty textbox to the maxmimum orderable qty
				else
				{
					//check remaining qty with currently ordered qty
					int remainingQuantity = orderedProduct.quantityInStock - currentlyOrderedQty;
					MessageBox.Show("The stock is not enough!\nRemaining stock: " + remainingQuantity.ToString());
					pc.ProductQty = remainingQuantity.ToString();
				}//end
			};//end lambda
		}//ef	
			
		
		private void updateOrderListView()
		{
			bool freeItemBool = false;
			string freeProductName = "";
			double subtotal = 0;
			double grandTotal = 0;
			listViewOrder.Items.Clear();
			updateOrderId();
			
			foreach (orderDetails item in Global.orderdetails)
			{
				//get productName from productId in order to show on listview
				string productName = Product.getProductNameById(item.productId);
				
				//item name
				ListViewItem newRow = new ListViewItem(productName);
				//item qty
				newRow.SubItems.Add(item.quantity.ToString());
				//item price each
				newRow.SubItems.Add(item.price.ToString("#,##0"));
				//total for each item
				newRow.SubItems.Add((item.quantity * item.price).ToString("#,##0"));
				
				subtotal += item.quantity * item.price;
				
				listViewOrder.Items.Add(newRow);
				
				//search for free item for the product
				Product product = searchProductByName(productName);
				Product freeProduct = checkFreeItem(product);
				
				//if there is free item, then boolean is true
				if (freeProduct != null)
				{
					freeItemBool = true;
					freeProductName = freeProduct.productName;
				}//end
			}//end loop
			
			//show subtotal
			lblSubtotal.Text = subtotal.ToString("#,##0.00");
			
			//calculate grandtotal with discount
			double discount = double.Parse(lblDiscount.Text);
			
			//if discount is < 0 and >= 1 (value is negative decimal), then it is a percent discount
			if (discount < 0 && discount >= -1)
			{
				//change the discount label to the discount amount
				lblDiscount.Text =  (subtotal * discount).ToString("#,##0.00");
				
				grandTotal = subtotal * (1 + discount);
				lblGrandTotal.Text = grandTotal.ToString("#,##0.00");
			}
			//else it's an integer value discount
			else
			{
				//the operand is plus because retrieved value is negative
				grandTotal = subtotal + discount;
				lblGrandTotal.Text = grandTotal.ToString("#,##0.00");
			}//end
			
			
			//show free item
			if (freeItemBool)
			{
				lblFreeItem.Text = freeProductName;
			}
			else
			{
				//this one helps when we delete the product contains freeitem from the listview
				lblFreeItem.Text = "-";
			}//end
		}//ef
			
		
		private Product checkFreeItem(Product product)
		{
			string sql = "SELECT promotionProduct, freeItem FROM promotions";
			DataTable resultTable = dm1.GetDataTable(sql);
			
			foreach (DataRow row in resultTable.Rows)
			{
				//check if there is free item for the product
				if (row[0].ToString() == product.productName)
				{
					//return free product
					Product freeItem = searchProductByName(row[1].ToString());
					return freeItem;
				}//end
			}//end loop
			return null;
		}//ef
		
		

		
		private Product searchProductByName(string productName)
		{
			//get productTitle from productcard
			string searchedProduct = productName;
			//loop through each product to search for the same name
			foreach (Product product in Global.products)
			{
				if (product.productName == searchedProduct)
				{
					return product;
				}//end if
			}//end loop
			//if nothing is found, then return null
			return null;
		}//ef
		
		
		private orderDetails searchOrderByProduct(Product product)
		{
			foreach(orderDetails item in Global.orderdetails)
			{
				if(item.productId == product.productId)
				{
					return item;
				}//end if
			}//end loop
			return null;
		}//ef
		

		private void addOrder(Product product, int qty)
		{
			//get orderId from Label
			int orderId 		= int.Parse(lblOrderId.Text);
			
			orderDetails order = searchOrderByProduct(product);
			Product freeProduct = checkFreeItem(product);
			
			//check if the order already exists
			if(order != null)
			{
				order.quantity += qty;
			}
			else
			{
				//add the order into the orderDetails
				Global.orderdetails.Add(new orderDetails(orderId, product.productId, qty, product.productPrice));
			}//end
			updateOrderListView();
			
		}//ef		

		
		void BtnOrderCheckoutClick(object sender, EventArgs e)
		{
			//if there is missing info, then let the user input them
			if (findMissingInfo())
			{
				return;
			}//end
			
			recorderOrdersTable();
			
			
			recordOrderDetailsTable();
			
			updateStock();
			
			//record free item given and update its stock
			recordFreeItemGiven();
			
			//record coupon used
			recordCouponUse();

			//reload the product information again
			Global.products = Product.loadProductInfo();
			
			//reload the product cards again
			showProductList();
			
			MessageBox.Show("Order Confirmed.");
			
			//clear info 
			clearInformationAfterCheckout();
		}//ef
		
		private bool findMissingInfo()
		{
			if (lblCustomerId.Text == "<id>" && cmbPaymentType.Text == "")
			{
				MessageBox.Show("Please enter the blank fields!");
				return true;
			}
			else
			{
				return false;
			}//end
		}//ef
		
		
		private void recorderOrdersTable()
		{
			//add order into orders table in database
			//get orderId from label
			string orderId		= lblOrderId.Text;
			
			//get customerId
			string customerId	= lblCustomerId.Text;
			
			DateTime todayDate	= DateTime.Now;
			
			//mySQL database datetime format = yyyy/MM/dd hh:mm
			string orderDate	= string.Format("{0}/{1}/{2}", todayDate.Year, todayDate.Month, todayDate.Day);

			string shippingDate	= dtpShippingDate.Text;
			
			
			//get total with removing thousand separator and decimals
			string total		= lblGrandTotal.Text.Replace(",", "");
			//delete decimals
			total 				= total.Substring(0, total.Length-3);
			
			string paymentType	= cmbPaymentType.Text;
			
			
			//insert into orders table
			string sql = "INSERT INTO orders(orderId, customerId, orderDate, shippingDate, orderStatus, total, paymentType) " +
						 "VALUES ('d1', 'd2', 'd3', 'd4', 'd5', 'd6', 'd7')";
			
			sql = sql.Replace("d1", orderId);
			sql = sql.Replace("d2", customerId);
			sql = sql.Replace("d3", orderDate);
			
			if (cmbShipping.Text == "Yes")
			{
				//if shipping if required, then insert shipping date
				sql = sql.Replace("d4", shippingDate);
				sql = sql.Replace("d5", "Shipping");	
			}
			else 
			{
				//record 1900-01-01 as a null value
				sql = sql.Replace("d4", "1900-01-01");
				sql = sql.Replace("d5", "Complete");	
			}
			
			sql = sql.Replace("d6", total);
			sql = sql.Replace("d7", paymentType);
			
			
			dm1.ExecuteNonQuery(sql);
		}//ef
		
		
		private void recordOrderDetailsTable()
		{
			//add orderdetails into orderdetails table in database
			string sql = "INSERT INTO orderdetails(orderId, productId, quantity, price) " +
				  		 "VALUES ";
			
			foreach (orderDetails item in Global.orderdetails)
			{
				sql += string.Format(" ('{0}', '{1}', '{2}', '{3}'),", 
				                     item.orderId, item.productId, item.quantity, item.price);
			}//end loop
			//To delete the comma at the end of VALUES
			sql = sql.Substring(0, sql.Length-1);
				
			//let datamanger insert multiple orderItems
			dm1.ExecuteNonQuery(sql);
		}//ef
		
		private void recordFreeItemGiven()
		{
			string freeItem = lblFreeItem.Text;
			//check if there is free item
			if (freeItem != "-")
			{
				//update promotion use count
				string sql = "UPDATE promotions SET useCount = useCount + 1";
				dm1.ExecuteNonQuery(sql);
				
				//update the stock
				//convert item into Id
				Product freeProduct = searchProductByName(freeItem);				
				
				sql = "UPDATE products SET quantityInStock = quantityInStock - 1 " +
					  "WHERE productId = 'd1'";
				
				sql = sql.Replace("d1", freeProduct.productId.ToString());
				
				dm1.ExecuteNonQuery(sql);
			}//end
		}//ef
		
		
		private void recordCouponUse()
        {
			string couponUsed = cmbDiscount.Text;

			//check if there is couponused
			if (couponUsed != "")
			{
				// INSERT INTO couponsuse (couponCode, orderId) VALUES ('DISCOUNT200', '11')
				string sql = "INSERT INTO couponsuse (couponCode, orderId) VALUES ('d1', 'd2')";
				sql = sql.Replace("d1", cmbDiscount.Text);
				sql = sql.Replace("d2", lblOrderId.Text);

				dm1.ExecuteNonQuery(sql);
			}//end
    	}//ef
		
		private void updateStock()
		{
			//reduce the stock
			foreach (orderDetails item in Global.orderdetails)
			{
				string sql = "UPDATE products SET quantityInStock = quantityInStock - 'd1'" +
					  		 "WHERE productId = 'd2'";
				sql = sql.Replace("d1", item.quantity.ToString());
				sql = sql.Replace("d2", item.productId.ToString());
				
				dm1.ExecuteNonQuery(sql);
			}//end loop
		}//ef
		
		private void clearInformationAfterCheckout()
		{
			listViewOrder.Items.Clear();
			
			//update order id
			updateOrderId();
			
			//delete payment info
			lblGrandTotal.Text = lblSubtotal.Text = lblDiscount.Text = "0";
			
			//clear textboxes
			txtProductSearch.Text = cmbCustName.Text = cmbPaymentType.Text = cmbDiscount.Text = "";
			
			//clear labels
			lblCustomerId.Text = lblCustomerName.Text = lblCustomerCity.Text = lblCustomerPhone.Text = lblFreeItem.Text = "-";
			
			//clear orderdetails list
			Global.orderdetails.Clear();
		}//ef
		
		
		private double findDiscount() 
		{
			string discountCode = cmbDiscount.Text;
			
			string sql = "SELECT * FROM coupons";
			DataTable coupons = dm1.GetDataTable(sql);
			
			foreach (DataRow coupon in coupons.Rows)
			{
				if (coupon[0].ToString() == discountCode && coupon[1].ToString() == "active")
				//if discountCode is equal to couponCode in database and if the code is still active
				{
					//return the discount amount
					return -double.Parse(coupon[2].ToString());
				}//end if
			}//end loop
			//if not then return 0
			return 0;
		}//ef
	
		
		
		void BtnApplyDiscountClick(object sender, EventArgs e)
		{
        	double discount = 0;
			discount = findDiscount();
			
			//check if the code is correct
			if (discount != 0)
			{
				lblDiscount.Text = discount.ToString();
				//update the listview
				updateOrderListView();
			}
			else
			{
				//show error message
				MessageBox.Show("The code is invalid.");
			}//end

		}//ef
		
		
		private void productSearchAutoComplete()
		{
			AutoCompleteStringCollection productList = new AutoCompleteStringCollection();
			
			string sql = "SELECT productName FROM products";
			DataTable result = dm1.GetDataTable(sql);
			
			foreach(DataRow row in result.Rows)
			{
				productList.Add(row[0].ToString());
			}//end loop
			
			txtProductSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			txtProductSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
			txtProductSearch.AutoCompleteCustomSource = productList;
		}//ef
		
		
		private void paymentTypeAutoComplete()
		{
			AutoCompleteStringCollection paymentTypes = new AutoCompleteStringCollection();
			
			//add autocomplete from the data source in combobox dropdown
			for (int i = 0; i < cmbPaymentType.Items.Count; i++)
			{
				paymentTypes.Add(cmbPaymentType.Items[i].ToString());
			}//end loops
			
			cmbPaymentType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cmbPaymentType.AutoCompleteSource = AutoCompleteSource.CustomSource;
			cmbPaymentType.AutoCompleteCustomSource = paymentTypes;
		}//ef
		
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			string productName = listViewOrder.SelectedItems[0].SubItems[0].Text;
			//get product
			Product product = searchProductByName(productName);
			//get order
			orderDetails order = searchOrderByProduct(product);
			//remove order from the list
			Global.orderdetails.Remove(order);
			//update listview
			updateOrderListView();
		}//ef
		
		
		
		private void shippingAutoComplete()
		{
			AutoCompleteStringCollection shipping = new AutoCompleteStringCollection();
			
			//add autocomplete from the data source in combobox dropdown
			for (int i = 0; i < cmbShipping.Items.Count; i++)
			{
				shipping.Add(cmbShipping.Items[i].ToString());
			}//end loops
			
			cmbShipping.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cmbShipping.AutoCompleteSource = AutoCompleteSource.CustomSource;
			cmbShipping.AutoCompleteCustomSource = shipping;
		}//ef
		
		private void discountCodeAutoComplete()
		{
			AutoCompleteStringCollection discountCodes = new AutoCompleteStringCollection();
			
			string sql = "SELECT couponCode FROM coupons";
			DataTable result = dm1.GetDataTable(sql);
			
			foreach(DataRow row in result.Rows)
			{
				discountCodes.Add(row[0].ToString());
			}//end loops
			
			cmbDiscount.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cmbDiscount.AutoCompleteSource = AutoCompleteSource.CustomSource;
			cmbDiscount.AutoCompleteCustomSource = discountCodes;
			cmbDiscount.DataSource = discountCodes;
			
			//make the default as empty
			cmbDiscount.Text = "";
		}//ef
		
		void CmbShippingTextChanged(object sender, EventArgs e)
		{
			if (cmbShipping.Text == "Yes")
			{
				//enable shipping datepicker when shipping is required
				dtpShippingDate.Enabled = true;
				lblShipping.Text = dtpShippingDate.Text;
			}
			else
			{
				dtpShippingDate.Enabled = false;
				lblShipping.Text = "-";
			}//end
		}//ef
		
		
		private void getCustomerNames(AutoCompleteStringCollection dataCollection)
		{
			string sql = "SELECT firstName, lastName FROM customers";
			
			DataTable result = dm1.GetDataTable(sql);

			
			foreach(DataRow row in result.Rows)
			{
				dataCollection.Add(row[0].ToString() + " " + row[1].ToString());
			}//end loop
		}//ef
			
		
		private void addCustomerSuggestion()
		{
			//this function add autocomplete feature on customer name textbox
			cmbCustName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			
			cmbCustName.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			AutoCompleteStringCollection customerNames = new AutoCompleteStringCollection();
            getCustomerNames(customerNames);
            cmbCustName.AutoCompleteCustomSource = customerNames;
            cmbCustName.DataSource				 = customerNames; 
		}//ef
		
		void CmbCustomerNameTextChanged(object sender, EventArgs e)
		{
			string[] customerName	 = cmbCustName.Text.Split(' ');
			
			if(customerName.Length > 1)
			{
				string customerFirstName = customerName[0];
													   //prevent when there is a space in firstname
				string customerLastName	 = customerName[1];
				
				string sql = "SELECT customerId, firstName, lastName, phone, city FROM customers " +
					"WHERE firstName = 'd1' AND lastName = 'd2'";
				sql = sql.Replace("d1", customerFirstName);
				sql = sql.Replace("d2", customerLastName);
				
				DataTable resultTable = dm1.GetDataTable(sql);
				
				if (resultTable.Rows.Count > 0)
				{
					//convert info into string
					string id			= resultTable.Rows[0][0].ToString();
					string firstName	= resultTable.Rows[0][1].ToString();
					string lastName		= resultTable.Rows[0][2].ToString();
					string phone		= resultTable.Rows[0][3].ToString();
					string city			= resultTable.Rows[0][4].ToString();
					
					lblCustomerId.Text		 = id;
					lblCustomerName.Text	 = firstName + " " + lastName;
					lblCustomerPhone.Text	 = phone;
					lblCustomerCity.Text	 = city;
				}//end if
			}//end
		}//ef
		
		
		void TxtProductSearchTextChanged(object sender, EventArgs e)
		{
			foreach (var item in flpProductList.Controls)
			{
				var pc = (ProductCard)item;
				//set the product card to be visible only when its title contain letters same as the search textbox
				pc.Visible = pc.ProductTitle.ToLower().Contains(txtProductSearch.Text.Trim().ToLower());
			}//end loop
		}//ef
		
		void CmbPaymentTypeTextChanged(object sender, EventArgs e)
		{
			lblPaymentMethod.Text = cmbPaymentType.Text;
		}//ef
		

		
		void DtpShippingDateValueChanged(object sender, EventArgs e)
		{
			lblShipping.Text = dtpShippingDate.Text;
		}//ef
	}//ec
}//en
