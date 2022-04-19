/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 16-Feb-22
 * Time: 12:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;

namespace termProject
{
	/// <summary>
	/// Description of Product.
	/// </summary>
	public class Product
	{
		public string productName, productType, description;
		public int productId, quantityInStock;
		public double productPrice;
		
		
		public Product()
		{
		}//econ
		
		public Product(int productId, string productName, string productType, int quantityInStock, double productPrice, string description)
		{
			this.productId = productId;
			this.productName = productName;
			this.productType = productType;
			this.description = description;
			this.quantityInStock = quantityInStock;
			this.productPrice = productPrice;
			
		}//econ
		
		public static List<Product> loadProductInfo()
		{
			string sql = "SELECT * FROM products";
			DataManager dm1 = new DataManager("localhost", "project", "root", "");
			
			DataTable resultTable = dm1.GetDataTable(sql);
			
			//create a new product list for keeping list of products in the store
			List<Product> products = new List<Product>();
			
			foreach(DataRow row in resultTable.Rows)
			{
				int productId				 = int.Parse(row[0].ToString());
				string productName			 = row[1].ToString();
				string productType			 = row[2].ToString();
				int quantityInStock			 = int.Parse(row[3].ToString());
				double productPrice			 = double.Parse(row[4].ToString());
				string productDescription	 = row[5].ToString();
				
				products.Add(new Product(productId, productName, productType, quantityInStock, productPrice, productDescription));
			}//endLoop 
			return products;
		}//ef
		
		public static string getProductNameById(int id)
		{
			DataManager dm1 = new DataManager("localhost", "project", "root", "");
			
			//get productName from productId in order to show on listview
			string sql = "SELECT productName FROM products " +
						 "WHERE productId='d1'";
			sql = sql.Replace("d1", id.ToString());
			DataTable result = dm1.GetDataTable(sql);
			string productName = result.Rows[0][0].ToString();
			return productName;
		}//ef
		
	}//ec
}//en
