/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 08-Feb-22
 * Time: 10:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace termProject
{
	/// <summary>
	/// Description of FrmProduct.
	/// </summary>
	public partial class FrmProduct : Form
	{
		DataManager dm1 = new DataManager("localhost", "project", "root", "");
		
		//Keep upload file path
		string uploadFilePath;
		
		public FrmProduct()
		{
			InitializeComponent();
			
			//add datasource to product type combobox
			addProductTypeSource();
		}//econ
		
		void FrmProductLoad(object sender, EventArgs e)
		{
			displayAllProducts();
		}//ef
		
		private void displayAllProducts()
		{
			//clear the listview
			listViewProduct.Items.Clear();
			
			//every time displayallproducts is called, we also update global.products to update add/update/delete products
			Global.products = Product.loadProductInfo();
			
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
		
		void BtnProductAddClick(object sender, EventArgs e)
		{	
			//get data from textboxes
			string productName 			= txtProductName.Text;
			string productType 			= cmbProductType.Text;
			string quantityInStock		= txtProductQty.Text;
			string productPrice		 	= txtProductPrice.Text;
			string productDescription 	= txtProdDes.Text;
			
			//check existing product by productName
			if(!checkExistingProduct(ProductName))
			{
				//sql statement
				string sql = "INSERT INTO products(productId, productName, productType, quantityInStock, productPrice, description) ";
				sql += "VALUES(null, 'd1', 'd2', 'd3', 'd4', 'd5')";
				sql = sql.Replace("d1", productName);
				sql = sql.Replace("d2", productType);
				sql = sql.Replace("d3", quantityInStock);
				sql = sql.Replace("d4", productPrice);
				sql = sql.Replace("d5", productDescription);
				
				dm1.ExecuteNonQuery(sql);
				
				//upload product image
				uploadToImageFolder();
				
				//update the customer query
				displayAllProducts();
				
				MessageBox.Show("Added successfully.");
				
				//clear information
				clearInformation();
			}
			else
			{
				MessageBox.Show("The product is already existed!");
				return;
			}//end
		}//ef
	
		void BtnProductDeleteClick(object sender, EventArgs e)
		{
			string productId = listViewProduct.SelectedItems[0].SubItems[0].Text;
			
			//create a confirmation popup
			var confirmationPopup = MessageBox.Show("Are you sure to delete this record?", "", MessageBoxButtons.YesNo);
			
			if (confirmationPopup == DialogResult.Yes)
			{
				string sql = "DELETE FROM products " +
					"WHERE productId='d0'";
				
				sql = sql.Replace("d0", productId);
				
				dm1.ExecuteNonQuery(sql);
				
				MessageBox.Show("Deleted successfully.");
				
				//update query
				displayAllProducts();
				
				//clear information
				clearInformation();
			}//end
			
		}//ef
		
		void BtnProductUpdateClick(object sender, EventArgs e)
		{
			string productId = listViewProduct.SelectedItems[0].SubItems[0].Text;
			
			//get data from textboxes
			string productName 			= txtProductName.Text;
			string productType 			= cmbProductType.Text;
			string quantityInStock		= txtProductQty.Text;
			string productPrice		 	= txtProductPrice.Text;
			string productDescription 	= txtProdDes.Text;
			
			string sql = "UPDATE products SET productName='d1', productType='d2', quantityInStock='d3', productPrice='d4', description='d5' " +
						 "WHERE productId='d0'";
			
			sql = sql.Replace("d0", productId);
			sql = sql.Replace("d1", productName);
			sql = sql.Replace("d2", productType);
			sql = sql.Replace("d3", quantityInStock);
			sql = sql.Replace("d4", productPrice);
			sql = sql.Replace("d5", productDescription);
			
			dm1.ExecuteNonQuery(sql);
			
			displayAllProducts();
			
			MessageBox.Show("Updated successfully.");
			
			//clear information
			clearInformation();
		}//ef
		
		private bool checkExistingProduct(string productName)
		{
			foreach(Product p in Global.products)
			{
				if(productName == p.productName)
				{
					return true;
				}//end
			}//eloop
			return false;
		}//ef

		
		private void getProductTypes(AutoCompleteStringCollection dataCollection)
		{
			string sql = "SELECT productType FROM producttypes";
			
			DataTable result = dm1.GetDataTable(sql);

			
			foreach(DataRow row in result.Rows)
			{
				dataCollection.Add(row[0].ToString());
			}//end loop
		}//ef
		
		
		private void addProductTypeSource()
		{
			cmbProductType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			
			cmbProductType.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			AutoCompleteStringCollection productTypes = new AutoCompleteStringCollection();
            getProductTypes(productTypes);
            cmbProductType.AutoCompleteCustomSource = productTypes;
            
            cmbProductType.DataSource = productTypes;
		}//ef
		
		void TxtProductSearchTextChanged(object sender, EventArgs e)
		{
			displaySearchedProducts();
		}//ef
		
		void CmbProductTypeKeyPress(object sender, KeyPressEventArgs e)
		{
		//	cmbProductType.DroppedDown = false;	
		}//ef
		
		void ListViewProductSelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewProduct.SelectedItems.Count > 0)
			{
				//get data from selected row and show them on textboxes
				txtProductName.Text		 = listViewProduct.SelectedItems[0].SubItems[1].Text;
				cmbProductType.Text		 = listViewProduct.SelectedItems[0].SubItems[2].Text;
				txtProductQty.Text		 = listViewProduct.SelectedItems[0].SubItems[3].Text;
				txtProductPrice.Text	 = listViewProduct.SelectedItems[0].SubItems[4].Text;
				txtProdDes.Text			 = listViewProduct.SelectedItems[0].SubItems[5].Text;
				picProduct.Image		 = Image.FromFile("image/" + txtProductName.Text + ".jpg");
				
			}
			else
			{
				//if not selecting the row, then empty the textboxes
				clearInformation();
			}//end
		}//ef
		
		private void clearInformation()
		{
			txtProductName.Text	 = "";
			cmbProductType.Text	 = "";
			txtProductQty.Text	 = "";
			txtProductPrice.Text = "";
			txtProdDes.Text		 = "";
			lblUploadName.Text	 = "";
			picProduct.Image	 = null;
		}//ef
		
		void BtnUploadClick(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Image files(*.jpg;)|*.jpg;";
			if(open.ShowDialog() == DialogResult.OK)
			{
				//store file path
				uploadFilePath = open.FileName;
				//get only filename without directory 
				string[] fileNameArr = uploadFilePath.Split('\\');
				string fileName		 = fileNameArr[fileNameArr.Length-1];
				lblUploadName.Text	 = fileName;
			}//end if
		}//ef
		
		private void uploadToImageFolder()
		{
			//save the file in the folder "image"
			File.Copy(uploadFilePath, Path.Combine("image/", Path.GetFileName(txtProductName.Text+".jpg")), true);
		}//ef
	}//ec
}//en
