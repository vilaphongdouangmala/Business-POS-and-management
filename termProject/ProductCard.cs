/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 17-Feb-22
 * Time: 7:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace termProject
{
	/// <summary>
	/// Description of ProductCard.
	/// </summary>
	public partial class ProductCard : UserControl
	{		
		
		public ProductCard()
		{
			this.Size = new Size(200, 186);
			
			InitializeComponent();
		}//econ
				
		//create properties of labels and picturebox
		public string ProductTitle {
			get { return lblProductName.Text; }
			set { lblProductName.Text = value; }
		}//end property
		
		public string ProductPrice {
			get { return lblProductPrice.Text; }
			set { lblProductPrice.Text = value; }
		}//end property
			
		public Image ProductPic {
			get { return pbProductPic.Image; }
			set { pbProductPic.Image = value; }
		}//end property
		
		public string ProductQty {
			get { return txtProductQty.Text; }
			set { txtProductQty.Text = value; }
		}//end property
		
		public EventHandler addToList;
		
		
		
		void BtnIncQtyClick(object sender, EventArgs e)
		{
			Product product = searchProductByName(ProductTitle);
			if (int.Parse(txtProductQty.Text) + 1 <= product.quantityInStock)
			{
				txtProductQty.Text = (int.Parse(txtProductQty.Text) + 1).ToString();
			}//end
			else
			{
				//quantity already reaches maximum, then send a pop-up window
				MessageBox.Show("You have reached the maxmimum quantity.");
			}//end
		}//ef
		
		
		void BtnDecQtyClick(object sender, EventArgs e)
		{
			if (int.Parse(txtProductQty.Text) > 1)
			{
				txtProductQty.Text = (int.Parse(txtProductQty.Text) - 1).ToString();
			}//end
		}//ef
		
		
		void BtnAddToListClick(object sender, EventArgs e)
		{
			//get command
			addToList.Invoke(this, e);
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
		
	}//ec
}//en
