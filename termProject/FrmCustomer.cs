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
using System.Windows.Forms;
using System.Threading;

namespace termProject
{
	/// <summary>
	/// Description of FrmCustomer.
	/// </summary>
	public partial class FrmCustomer : Form
	{
		DataManager dm1 = new DataManager("localhost", "project", "root", "");
		
		
		public FrmCustomer()
		{

			InitializeComponent();
			
			//add datasource to customer type combobox
			addCustomerTypeSource();
			//add autocomplete to gender combobox
			addGenderAutoComplete();
			//add cities autocomplete
			addCityAutoComplete();
		}//econ
		
		
		void FrmCustomerLoad(object sender, EventArgs e)
		{
			//change datepicker format
			dtpCustDOB.Format = DateTimePickerFormat.Custom;
			dtpCustDOB.CustomFormat = "yyyy-MM-dd";
	
			displayAllCustomer();		
		}//ef
		
		private void displayAllCustomer()
		{
			//empty the listview
			listViewCust.Items.Clear();
			
			//customerId = 0 is a guest customer who doesn't have any an account
			string sql = "SELECT * FROM customers WHERE customerId != 0";
			
			//get data
			DataTable resultTable = dm1.GetDataTable(sql);
			
			//loop over each row in resultTable to display
			foreach(DataRow row in resultTable.Rows)
			{
				string customerId 	= row[0].ToString();
				string firstName 	= row[1].ToString();
				string lastName 	= row[2].ToString();
				string gender 		= row[3].ToString();
				string dob 			= row[4].ToString();
				string type 		= row[5].ToString();
				string phone 		= row[6].ToString();
				string address 		= row[7].ToString();
				string city 		= row[8].ToString();
				string email 		= row[9].ToString();
				
				//create a new listview row
				ListViewItem newRow = new ListViewItem(customerId);
				newRow.SubItems.Add(firstName);
				newRow.SubItems.Add(lastName);
				newRow.SubItems.Add(gender);
				newRow.SubItems.Add(DateTime.Parse(dob).ToString("yyyy-MM-dd"));
				newRow.SubItems.Add(type);
				newRow.SubItems.Add(phone);
				newRow.SubItems.Add(address);
				newRow.SubItems.Add(city);
				newRow.SubItems.Add(email);
				
				//add the rows into the list
				listViewCust.Items.Add(newRow);
			}//eloop			
		}//ef
		
		private void displaySearchedCustomer()
		{
			//empty the listview
			listViewCust.Items.Clear();
			
			//search customer by firstname or phone
			string search = txtCustSearch.Text;
			
			string sql = "SELECT * FROM customers " +
						 "WHERE (firstName LIKE '%d1%' OR lastName LIKE '%d1%' OR phone LIKE '%d1%') AND customerId != 0";
			
			sql = sql.Replace("d1", search);
			
			DataTable resultTable = dm1.GetDataTable(sql);
			
			//loop over each row in resultTable to display
			foreach(DataRow row in resultTable.Rows)
			{
				string customerId 	= row[0].ToString();
				string firstName 	= row[1].ToString();
				string lastName 	= row[2].ToString();
				string gender 		= row[3].ToString();
				string dob 			= row[4].ToString();
				string type 		= row[5].ToString();
				string phone 		= row[6].ToString();
				string address 		= row[7].ToString();
				string city 		= row[8].ToString();
				string email 		= row[9].ToString();
				
				//create a new listview row
				ListViewItem newRow = new ListViewItem(customerId);
				newRow.SubItems.Add(firstName);
				newRow.SubItems.Add(lastName);
				newRow.SubItems.Add(gender);
				newRow.SubItems.Add(DateTime.Parse(dob).ToString("yyyy-MM-dd"));
				newRow.SubItems.Add(type);
				newRow.SubItems.Add(phone);
				newRow.SubItems.Add(address);
				newRow.SubItems.Add(city);
				newRow.SubItems.Add(email);
				
				//add the rows into the list
				listViewCust.Items.Add(newRow);
			}//eloop			
		}//ef
		
		void BtnCustAddClick(object sender, EventArgs e)
		{		
			//get data from textboxes
			string firstName = txtCustFirstName.Text;
			string lastName  = txtCustLastName.Text;
			string gender	 = cmbCustGender.Text;
			string dob		 = dtpCustDOB.Text;
			string type		 = cmbCustType.Text;
			string phone	 = txtCustPhone.Text;
			string address	 = txtCustAddress.Text;
			string city		 = cmbCustCity.Text;
			string email	 = txtCustEmail.Text;
			
			//sql statement
			string sql = "INSERT INTO customers(customerId, firstName, lastName, gender, DOB, customerType, phone, address, city, email) ";
			sql += "VALUES(null, 'd1', 'd2', 'd3', 'd4', 'd5', 'd6', 'd7', 'd8', 'd9')";                             
			sql = sql.Replace("d1", firstName);
			sql = sql.Replace("d2", lastName);
			sql = sql.Replace("d3", gender);
			sql = sql.Replace("d4", dob);
			sql = sql.Replace("d5", type);
			sql = sql.Replace("d6", phone);
			sql = sql.Replace("d7", address);
			sql = sql.Replace("d8", city);
			sql = sql.Replace("d9", email);
			
			dm1.ExecuteNonQuery(sql);
			
			//update the customer query
			displayAllCustomer();
			
			MessageBox.Show("Added successfully.");
			
			//clear Information
			clearInformation();
		}//ef
			
		void BtnCustDeleteClick(object sender, EventArgs e)
		{
			string customerId = listViewCust.SelectedItems[0].SubItems[0].Text;
			
			//create a confirmation popup
			var confirmationPopup = MessageBox.Show("Are you sure to delete this record?", "", MessageBoxButtons.YesNo);
			
			if (confirmationPopup == DialogResult.Yes)
			{
				string sql = "DELETE FROM customers ";
				sql += "WHERE customerId='d0'";
				
				sql = sql.Replace("d0", customerId);
				
				dm1.ExecuteNonQuery(sql);
				
				//update the customer query
				displayAllCustomer();
				
				MessageBox.Show("Deleted successfully.");
				
				//clear Information
				clearInformation();
			}//eif		
		}//ef
		
		void BtnCustUpdateClick(object sender, EventArgs e)
		{
			//get id from selected row
			string customerId = listViewCust.SelectedItems[0].SubItems[0].Text;
			
			//get data from textboxes
			string firstName = txtCustFirstName.Text;
			string lastName  = txtCustLastName.Text;
			string gender	 = cmbCustGender.Text;
			string dob		 = dtpCustDOB.Text;
			string type		 = cmbCustType.Text;
			string phone	 = txtCustPhone.Text;
			string address	 = txtCustAddress.Text;
			string city		 = cmbCustCity.Text;
			string email	 = txtCustEmail.Text;
			
			string sql = "UPDATE customers SET firstName='d1', lastName='d2', gender='d3', DOB='d4', customerType='d5', " +
						 "phone='d6', address='d7', city='d8', email='d9'" +
						 "WHERE customerId = 'd0'";
			
			sql = sql.Replace("d0", customerId);
			sql = sql.Replace("d1", firstName);
			sql = sql.Replace("d2", lastName);
			sql = sql.Replace("d3", gender);
			sql = sql.Replace("d4", dob);
			sql = sql.Replace("d5", type);
			sql = sql.Replace("d6", phone);
			sql = sql.Replace("d7", address);
			sql = sql.Replace("d8", city);
			sql = sql.Replace("d9", email);
			
			dm1.ExecuteNonQuery(sql);
			
			//update the customer query
			displayAllCustomer();
			
			MessageBox.Show("Updated successfully.");
			
			//clear Information
			clearInformation();
			
		}//ef
		
		void ListViewCustSelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewCust.SelectedItems.Count > 0)
			{
				//get data from selected row and show them on textboxes
				txtCustFirstName.Text	 = listViewCust.SelectedItems[0].SubItems[1].Text;
				txtCustLastName.Text	 = listViewCust.SelectedItems[0].SubItems[2].Text;
				cmbCustGender.Text		 = listViewCust.SelectedItems[0].SubItems[3].Text;
				dtpCustDOB.Text			 = listViewCust.SelectedItems[0].SubItems[4].Text;
				cmbCustType.Text		 = listViewCust.SelectedItems[0].SubItems[5].Text;
				txtCustPhone.Text		 = listViewCust.SelectedItems[0].SubItems[6].Text;
				txtCustAddress.Text		 = listViewCust.SelectedItems[0].SubItems[7].Text;
				cmbCustCity.Text		 = listViewCust.SelectedItems[0].SubItems[8].Text;
				txtCustEmail.Text		 = listViewCust.SelectedItems[0].SubItems[9].Text;
			}
			else
			{
				//if not selecting the row, then empty the textboxes
				clearInformation();

			}//end
		}//ef
		
		private void clearInformation()
		{
			txtCustFirstName.Text = "";
			txtCustLastName.Text = "";
			cmbCustGender.Text = "";
			dtpCustDOB.Text = "";
			cmbCustType.Text = "";
			txtCustPhone.Text = "";
			txtCustAddress.Text = "";
			cmbCustCity.Text = "";
			txtCustEmail.Text = "";
		}//ef
			
		void TxtCustSearchTextChanged(object sender, EventArgs e)
		{
			displaySearchedCustomer();
		}//ef
		
		
		private void getCustomerTypes(AutoCompleteStringCollection dataCollection)
		{
			string sql = "SELECT customerType FROM customertypes";
			
			DataTable result = dm1.GetDataTable(sql);

			
			foreach(DataRow row in result.Rows)
			{
				dataCollection.Add(row[0].ToString());
			}//end loop
		}//ef
		
		
		private void addCustomerTypeSource()
		{
			cmbCustType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			
			cmbCustType.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			AutoCompleteStringCollection customerTypes = new AutoCompleteStringCollection();
            getCustomerTypes(customerTypes);
            cmbCustType.AutoCompleteCustomSource = customerTypes;
            
            cmbCustType.DataSource = customerTypes;
		}//ef
		
		private void addGenderAutoComplete()
		{
			cmbCustGender.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cmbCustGender.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			AutoCompleteStringCollection genders = new AutoCompleteStringCollection();
			
			genders.Add("Male");
			genders.Add("Female");
			genders.Add("LGBT");
			
			cmbCustGender.AutoCompleteCustomSource = genders;
			cmbCustGender.DataSource = genders;
		}//ef
		
		
		private void addCityAutoComplete()
		{
			cmbCustCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cmbCustCity.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			AutoCompleteStringCollection cities = new AutoCompleteStringCollection();
			
			//sample cities
			cities.Add("Toronto");
			cities.Add("Quebec City");
			cities.Add("Vancouver");
			
			cmbCustCity.AutoCompleteCustomSource = cities;
			cmbCustCity.DataSource = cities;
		}//end
		
	}//ec
}//en
