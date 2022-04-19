/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 22-Feb-22
 * Time: 5:38 PM
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
	/// Description of FrmInventory.
	/// </summary>
	public partial class FrmInventory : Form
	{
		DataManager dm1 = new DataManager("localhost", "project", "root", "");
		
		public FrmInventory()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			displayAllProducts();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}//econ
		
		
		void FrmInventoryLoad(object sender, EventArgs e)
		{
			displayAllProducts();
			
			adjustViewByRole();
		}//ef
		
		private void displayAllProducts()
		{
			//clear the listview
			listViewProduct.Items.Clear();
			
			string sql = "SELECT * FROM products";
			
			DataTable resultTable = dm1.GetDataTable(sql);
			
			foreach (DataRow row in resultTable.Rows)
			{
				string productId 			= row[0].ToString();
				string productName 			= row[1].ToString();
				string productType 			= row[2].ToString();
				string qtyInStock			= row[3].ToString();
				string productPrice		 	= row[4].ToString();
				string productDescription 	= row[5].ToString();
				
				//createa a new listview item row
				ListViewItem newRow = new ListViewItem(productId);
				newRow.SubItems.Add(productName);
				newRow.SubItems.Add(productType);
				newRow.SubItems.Add(qtyInStock);
				newRow.SubItems.Add(double.Parse(productPrice).ToString("#,##0"));
				newRow.SubItems.Add(productDescription);		
				
				listViewProduct.Items.Add(newRow);
			}//eloop
		}//ef
		
		void ListViewProductSelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewProduct.SelectedItems.Count > 0)
			{
				//get data from selected row and show them on textboxes
				lblProductName.Text = listViewProduct.SelectedItems[0].SubItems[1].Text;
				lblProductQty.Text	= listViewProduct.SelectedItems[0].SubItems[3].Text;
				picProduct.Image	= Image.FromFile("image/" + lblProductName.Text + ".jpg");
			}
			else
			{
				lblProductName.Text = "";
				lblProductQty.Text	= "0";
				picProduct.Image	= null;
			}//end
		}//ef
		
		private void displaySearchedProducts()
		{
			listViewProduct.Items.Clear();
			
			string search = txtProductSearch.Text;
			
			string sql = "SELECT * FROM products " +
						 "WHERE productName LIKE '%d1%'";
			
			sql = sql.Replace("d1", search);
			
			DataTable resultTable = dm1.GetDataTable(sql);
			
			foreach (DataRow row in resultTable.Rows)
			{
				string productId 			= row[0].ToString();
				string productName 			= row[1].ToString();
				string productType 			= row[2].ToString();
				string qtyInStock			= row[3].ToString();
				string productPrice		 	= row[4].ToString();
				string productDescription 	= row[5].ToString();
				
				//createa a new listview item row
				ListViewItem newRow = new ListViewItem(productId);
				newRow.SubItems.Add(productName);
				newRow.SubItems.Add(productType);
				newRow.SubItems.Add(qtyInStock);
				newRow.SubItems.Add(double.Parse(productPrice).ToString("#,##0"));
				newRow.SubItems.Add(productDescription);		
				
				listViewProduct.Items.Add(newRow);
			}//eloop
		}//ef
		
		void BtnStockAddClick(object sender, EventArgs e)
		{
			//get the index of selected item to make it remain focused after clicking button
			var selectedItem = listViewProduct.SelectedItems[0];
			int selectedIndex = listViewProduct.Items.IndexOf(selectedItem);

			string productId	= listViewProduct.SelectedItems[0].SubItems[0].Text;
			string addedStock	= txtStockAdd.Text;
			
			//add product stock according to stockadd textbox
			string sql = "UPDATE products SET quantityInStock = quantityInStock + 'd1' " +
						 "WHERE productId = 'd2'";
			
			sql = sql.Replace("d1", addedStock);
			sql = sql.Replace("d2", productId);
			
			dm1.ExecuteNonQuery(sql);
			
			//update the listview
			displayAllProducts();
			
			//update qty label
			lblProductQty.Text = (int.Parse(lblProductQty.Text) + int.Parse(addedStock)).ToString();
			
			//clear add stock txt
			txtStockAdd.Text = "";
			
			MessageBox.Show("Product stock added successfully.");
			
			//make selected item to remain focused after clicking button
			listViewProduct.Items[selectedIndex].Selected = true;
						
			
		}//ef
		
		void BtnStockReduceClick(object sender, EventArgs e)
		{
			//get the index of selected item to make it remain focused after clicking button
			var selectedItem = listViewProduct.SelectedItems[0];
			int selectedIndex = listViewProduct.Items.IndexOf(selectedItem);
			
			string productId	= listViewProduct.SelectedItems[0].SubItems[0].Text;
			string reducedStock	= txtStockAdd.Text;
			
			string sql = "SELECT quantityInStock FROM products WHERE productId = 'd2'";
			sql = sql.Replace("d2", productId);
			DataTable retrievedQty = dm1.GetDataTable(sql);
			
			int currentQty = int.Parse(retrievedQty.Rows[0][0].ToString());
			
			if (currentQty >= int.Parse(reducedStock))
			{
				//reduce the qty if the stock is enough
				
				//add product stock according to stockadd textbox
				sql = "UPDATE products SET quantityInStock = quantityInStock - 'd1' " +
					"WHERE productId = 'd2'";
				
				sql = sql.Replace("d1", reducedStock);
				sql = sql.Replace("d2", productId);
				
				dm1.ExecuteNonQuery(sql);
				
				//update the listview
				displayAllProducts();
				
				//update qty label
				lblProductQty.Text = (int.Parse(lblProductQty.Text) - int.Parse(reducedStock)).ToString();
				
				//clear add stock txt
				txtStockAdd.Text = "";
				
				MessageBox.Show("Product stock reduced successfully.");
			}
			else
			{
				MessageBox.Show("The product stock is not enough!");
			}//end

			//make selected item to remain focused after clicking button
			listViewProduct.Items[selectedIndex].Selected = true;
			
			
		}//ef
		
		
		void LblProductQtyTextChanged(object sender, EventArgs e)
		{
			//this function change the qty label color to red if qty is less than 10
			
			//convert to int
			int qty = int.Parse(lblProductQty.Text);
			
			if (qty <= 5)
			{
				lblProductQty.ForeColor = System.Drawing.Color.Red;
				
			}
			else
			{
				lblProductQty.ForeColor = System.Drawing.Color.Black;
			}
				
		}//ef
		
		private void adjustViewByRole()
		{
			if (Global.user.role.ToLower() == "manager")
			{
				btnStockAdd.Enabled		 = false;
				btnStockAdd.BackColor	 = Color.White;
				btnStockReduce.Enabled	 = false;
				btnStockReduce.BackColor = Color.White;
			}//end
		}//ef
		
		

		
		void TxtProductSearchTextChanged(object sender, EventArgs e)
		{
			displaySearchedProducts();
		}//ef
	}//ec
}//en
