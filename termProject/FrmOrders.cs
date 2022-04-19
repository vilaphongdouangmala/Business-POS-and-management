/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 25-Mar-22
 * Time: 3:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace termProject
{
	/// <summary>
	/// Description of FrmOrders.
	/// </summary>
	public partial class FrmOrders : Form
	{
		DataManager dm1 = new DataManager("localhost", "project", "root", "");
		public FrmOrders()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}//econ
		
		void FrmOrdersLoad(object sender, EventArgs e)
		{			
			//change datepicker format
			dtpShippingDate.Format = DateTimePickerFormat.Custom;
			dtpShippingDate.CustomFormat = "yyyy-MM-dd";
			
			//set today's date
			lblTodayDate.Text = DateTime.Today.Date.ToString("dd-MMM-yyyy");
			
			//get autocomplete for cmb
			orderStatusAutoComplete();
			
			updateOrderListView();
			updateToBeShipListView();
		}//ef
		
		
		private void updateOrderListView()
		{
			listViewOrder.Items.Clear();
			
			string sql = "SELECT * FROM orders " +
						 "ORDER BY orderId DESC";
			
			DataTable resultTable = dm1.GetDataTable(sql);
			
			foreach(DataRow row in resultTable.Rows)
			{
				string orderId			 = row[0].ToString();
				string customerName		 = getCustomerFullNameById(row[1].ToString());
				string orderDate	 	 = row[2].ToString();
				DateTime shippingDate	 = Convert.ToDateTime(row[3].ToString());
				string orderStatus		 = row[4].ToString();
				double total			 = double.Parse(row[5].ToString());
				string paymentType		 = row[6].ToString();
				
				
				ListViewItem newRow = new ListViewItem(orderId);
				newRow.SubItems.Add(customerName);
				newRow.SubItems.Add(DateTime.Parse(orderDate).ToString("yyyy-MM-dd"));
				
				//if no shipping date (2000-01-01 means null)
				if(shippingDate.ToString("yyyy-MM-dd") != "2000-01-01")
				{
					newRow.SubItems.Add(shippingDate.ToString("yyyy-MM-dd"));
				}
				else
				{
					newRow.SubItems.Add("-");
				}//end
				newRow.SubItems.Add(orderStatus);
				newRow.SubItems.Add(paymentType);
				newRow.SubItems.Add(total.ToString("#,##0"));
				
				listViewOrder.Items.Add(newRow);
			}//eloop
		}//ef
		
		private void searchedOrderListView()
		{
			listViewOrder.Items.Clear();
			
			string searchOrder = txtSearch.Text;
			
			string sql = "SELECT o.orderId, o.customerId, o.orderDate, o.shippingDate, " +
						 "o.orderStatus, o.total, o.paymentType FROM orders o, customers c " +
						 "WHERE o.customerId = c.customerId AND (o.orderId LIKE '%d1%' OR c.firstName LIKE '%d1%' OR c.lastName LIKE '%d1%') " +
						 "ORDER BY orderId DESC";
			
			sql = sql.Replace("d1", searchOrder);
			
			DataTable resultTable = dm1.GetDataTable(sql);
			
			foreach(DataRow row in resultTable.Rows)
			{
				string orderId			 = row[0].ToString();
				string customerName		 = getCustomerFullNameById(row[1].ToString());
				string orderDate	 	 = row[2].ToString();
				DateTime shippingDate	 = Convert.ToDateTime(row[3].ToString());
				string orderStatus		 = row[4].ToString();
				double total			 = double.Parse(row[5].ToString());
				string paymentType		 = row[6].ToString();
				
				
				ListViewItem newRow = new ListViewItem(orderId);
				newRow.SubItems.Add(customerName);
				newRow.SubItems.Add(DateTime.Parse(orderDate).ToString("yyyy-MM-dd"));
				
				//if no shipping date (2000-01-01 means null)
				if(shippingDate.ToString("yyyy-MM-dd") != "2000-01-01")
				{
					newRow.SubItems.Add(shippingDate.ToString("yyyy-MM-dd"));
				}
				else
				{
					newRow.SubItems.Add("-");
				}//end
				newRow.SubItems.Add(orderStatus);
				newRow.SubItems.Add(paymentType);
				newRow.SubItems.Add(total.ToString("#,##0"));
				
				listViewOrder.Items.Add(newRow);
			}//eloop
		}//ef
		
		
		private void updateToBeShipListView()
		{
			listViewToBeShipped.Items.Clear();
			
			DateTime todayDate = DateTime.Today.Date;
			
			string sql = "SELECT o.orderId, CONCAT(c.firstName, ' ', c.lastName), c.address FROM orders o, customers c " +
						 "WHERE o.customerId = c.customerId AND o.orderDate = 'd1' AND o.orderStatus = 'Shipping'";
			
			sql = sql.Replace("d1", todayDate.ToString("yyyy-MM-dd"));
			
			DataTable resultTable = dm1.GetDataTable(sql);
			
			foreach(DataRow row in resultTable.Rows)
			{
				string orderId		 = row[0].ToString();
				string customerName	 = row[1].ToString();
				string address		 = row[2].ToString();
				
				ListViewItem newRow = new ListViewItem(orderId);
				newRow.SubItems.Add(customerName);
				newRow.SubItems.Add(address);
				
				listViewToBeShipped.Items.Add(newRow);
			}//eloop
			
		}//ef
		
		
		private string getCustomerFullNameById(string customerId)
		{
			string sql = "SELECT firstName, lastName FROM customers " +
						 "WHERE customerId = 'd0'";
			
			sql = sql.Replace("d0", customerId);
			
			DataTable resultTable = dm1.GetDataTable(sql);
			
			if(resultTable.Rows.Count > 0)
			{
				return resultTable.Rows[0][0].ToString() + " " + resultTable.Rows[0][1].ToString();			
			}		
			return null;
		}//ef

		void BtnUpdateClick(object sender, EventArgs e)
		{
			string orderId		 = listViewOrder.SelectedItems[0].SubItems[0].Text;
			string orderStatus	 = cmbOrderStatus.Text;
			string shippingDate	 = dtpShippingDate.Text;
			
			string sql = "UPDATE orders SET orderStatus='d1', shippingDate='d2'  " +
						 "WHERE orderId='d0'";
			sql = sql.Replace("d0", orderId);
			sql = sql.Replace("d1", orderStatus);
			sql = sql.Replace("d2", shippingDate);
			
			dm1.ExecuteNonQuery(sql);
			
			MessageBox.Show("The order has been updated.");
			
			updateOrderListView();
		}//ef
		

		void ListViewOrderSelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewOrder.SelectedItems.Count > 0)
			{
				lblOrderId.Text			 = listViewOrder.SelectedItems[0].SubItems[0].Text;
				lblCustomerName.Text	 = listViewOrder.SelectedItems[0].SubItems[1].Text;
				cmbOrderStatus.Text		 = listViewOrder.SelectedItems[0].SubItems[4].Text;
				//check if there is no shipping date
				string shippingDate 	 = listViewOrder.SelectedItems[0].SubItems[3].Text;
				if (shippingDate != "-")
				{
					dtpShippingDate.Text = shippingDate;
					dtpShippingDate.Enabled = true;
				}
				else
				{
					//if not then disable it
					dtpShippingDate.Enabled = false;
				}//end
			}
			else
			{
				lblOrderId.Text			 = "";
				lblCustomerName.Text	 = "";
				cmbOrderStatus.Text		 = "";
				dtpShippingDate.Text	 = "";
			}//end
		}//ef
		
		void TxtSearchTextChanged(object sender, EventArgs e)
		{
			searchedOrderListView();
		}//ef
		
		private void orderStatusAutoComplete()
		{
			cmbOrderStatus.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cmbOrderStatus.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			AutoCompleteStringCollection orderStatuses = new AutoCompleteStringCollection();
			
			//get statuses from database
			string sql = "SELECT orderStatus FROM orderstatus";
			
			DataTable resutlTable = dm1.GetDataTable(sql);
			
			foreach(DataRow row in resutlTable.Rows)
			{
				orderStatuses.Add(row[0].ToString());
			}//eloop;
			
			cmbOrderStatus.AutoCompleteCustomSource = orderStatuses;
			cmbOrderStatus.DataSource = orderStatuses;
		}//ef
		
		private void searchOrderWithDatePicker()
		{
			listViewOrder.Items.Clear();
			
			string searchedDate = dtpFilter.Value.Date.ToString("yyyy-MM-dd");
			
			string sql = "SELECT * FROM orders " +
						 "WHERE orderDate = 'd1'";
			
			sql = sql.Replace("d1", searchedDate);
				
			DataTable resultTable = dm1.GetDataTable(sql);
			
			foreach(DataRow row in resultTable.Rows)
			{
				string orderId			 = row[0].ToString();
				string customerName		 = getCustomerFullNameById(row[1].ToString());
				string orderDate	 	 = row[2].ToString();
				DateTime shippingDate	 = Convert.ToDateTime(row[3].ToString());
				string orderStatus		 = row[4].ToString();
				double total			 = double.Parse(row[5].ToString());
				string paymentType		 = row[6].ToString();
				
				
				ListViewItem newRow = new ListViewItem(orderId);
				newRow.SubItems.Add(customerName);
				newRow.SubItems.Add(DateTime.Parse(orderDate).ToString("yyyy-MM-dd"));
				
				//if no shipping date (2000-01-01 means null)
				if(shippingDate.ToString("yyyy-MM-dd") != "2000-01-01")
				{
					newRow.SubItems.Add(shippingDate.ToString("yyyy-MM-dd"));
				}
				else
				{
					newRow.SubItems.Add("-");
				}//end
				newRow.SubItems.Add(orderStatus);
				newRow.SubItems.Add(paymentType);
				newRow.SubItems.Add(total.ToString("#0,###.00"));
				
				listViewOrder.Items.Add(newRow);
			}//eloop
		}//ef
		
		void DtpFilterValueChanged(object sender, EventArgs e)
		{
			searchOrderWithDatePicker();
		}//ef
		
		void BtnRefreshClick(object sender, EventArgs e)
		{
			updateOrderListView();
		}//ef
	}//ec
}//en
