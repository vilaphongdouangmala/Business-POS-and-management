/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 15-Feb-22
 * Time: 7:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace termProject
{
	/// <summary>
	/// Description of orderDetails.
	/// </summary>
	public class orderDetails
	{
		public int orderId, productId, quantity;
		public double price;
		
		public orderDetails()
		{
		}//econ
		
		public orderDetails(int orderId, int productId, int quantity, double price)
		{
			this.orderId	= orderId;
			this.productId	= productId;
			this.quantity	= quantity;
			this.price		= price;
		}//econ
		
	}//ec
}//en
