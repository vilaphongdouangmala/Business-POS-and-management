/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 08-Feb-22
 * Time: 10:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace termProject
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		//private Form activeForm;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}//econ
		
		private void openForm(Form selectedForm, object btnSender)
		{
			selectedForm.TopLevel = false;
			selectedForm.FormBorderStyle = FormBorderStyle.None;
			selectedForm.Dock = DockStyle.Fill;
			this.pnlSelectedForm.Controls.Add(selectedForm);
			this.pnlSelectedForm.Tag = selectedForm;
			selectedForm.BringToFront();
			selectedForm.Show();
			
		}//ef
		
		void MainFormLoad(object sender, EventArgs e)
		{
			//open FrmPOS as default form
			openForm(new FrmPOS(), sender);
			
			//change the view by role
			adjustViewByRole();
		}//ef
		
		void BtnFrmPOSClick(object sender, EventArgs e)
		{
			openForm(new FrmPOS(), sender);
		}//ef
		
		void BtnFrmProductClick(object sender, EventArgs e)
		{
			openForm(new FrmProduct(), sender);
		}//ef
		
		void BtnFrmInventoryClick(object sender, EventArgs e)
		{
			openForm(new FrmInventory(), sender);
		}//ef
		
		void BtnFrmCustomerClick(object sender, EventArgs e)
		{
			openForm(new FrmCustomer(), sender);
		}//ef
		
		void BtnFrmOrderClick(object sender, EventArgs e)
		{
			openForm(new FrmOrders(), sender);
		}//ef
		
		void BtnFrmReportClick(object sender, EventArgs e)
		{
			openForm(new FrmReport(), sender);
		}//ef
		
		void BtnFrmEmployeeClick(object sender, EventArgs e)
		{
			openForm(new FrmEmployee(), sender);
		}//ef
		
		private void adjustViewByRole()
		{
			if (Global.user.role.ToLower() == "staff")
			{
				btnFrmEmployee.Visible	 = false;
				btnFrmReport.Visible	 = false;
			}//eif
		}//ef
	}//ec
}//en
