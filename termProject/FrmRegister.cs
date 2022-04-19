/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 26-Mar-22
 * Time: 1:22 PM
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
	/// Description of FrmRegister.
	/// </summary>
	public partial class FrmRegister : Form
	{
		DataManager dm1 = new DataManager("localhost", "project", "root", "");
		public FrmRegister()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}//econ
		
		private bool checkUserNamePassword()
		{
			//check whether the user has existing username
			string sql = "SELECT username, password FROM employees " +
						 "WHERE employeeId = 'd0'";
			sql = sql.Replace("d0", txtEmployeeId.Text);
			
			DataTable result = dm1.GetDataTable(sql);
			
			if (result.Rows[0][0].ToString() != "" && result.Rows[0][1].ToString() != "")
			{
				return true;
			}
			else
			{
				return false;
			}
		}//ef
		
		void BtnCreateClick(object sender, EventArgs e)
		{
			if(txtEmployeeId.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
			{
				//check whether the user has existing username
				if (checkUserNamePassword())
				{
					MessageBox.Show("You already have the username and password.");
					return;
				}
				
				//check if password and confirmation are matched
				if (txtConfirm.Text == txtPassword.Text)
				{
					string sql = "UPDATE employees SET username='d1', password='d2' " +
								 "WHERE employeeId = 'd0'";
					
					sql = sql.Replace("d0", txtEmployeeId.Text);
					sql = sql.Replace("d1", txtUsername.Text);
					sql = sql.Replace("d2", txtPassword.Text);
					
					dm1.ExecuteNonQuery(sql);
					
					MessageBox.Show("Create the user successfully.");
					this.Close();
				}
				else
				{
					MessageBox.Show("The passwords are not matched.");
				}
			}
			else
			{
				MessageBox.Show("Invalid input.");
			}	
		}//ef
		
		
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}//ef
		
		private void employeeIdAutoComplete()
		{
			txtEmployeeId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			txtEmployeeId.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			AutoCompleteStringCollection employeeIds = new AutoCompleteStringCollection();
			
			string sql = "SELECT employeeId FROM employees";
			
			DataTable resultTable = dm1.GetDataTable(sql);
			
			foreach(DataRow row in resultTable.Rows)
			{
				employeeIds.Add(row[0].ToString());
			}//eloop
			
			txtEmployeeId.AutoCompleteCustomSource = employeeIds;
		}//ef
		
		
		void TxtEmployeeIdTextChanged(object sender, EventArgs e)
		{
			string employeeId = txtEmployeeId.Text;
			
			string sql = "SELECT CONCAT(firstName, ' ', lastName) FROM employees " +
						 "WHERE employeeId = 'd0'";
			
			sql = sql.Replace("d0", employeeId);
			
			DataTable result = dm1.GetDataTable(sql);
			
			if(result.Rows.Count > 0)
			{
				lblEmployeeName.Text = result.Rows[0][0].ToString();
			}//end
			else
			{
				lblEmployeeName.Text = "-";
			}//end
		}//ef
		
		void FrmRegisterLoad(object sender, EventArgs e)
		{
			employeeIdAutoComplete();
			
		}//ef
	}//ec
}//en
