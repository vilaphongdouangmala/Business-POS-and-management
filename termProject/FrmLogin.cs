/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 08-Feb-22
 * Time: 10:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace termProject
{
    public partial class FrmLogin : Form
    {
        DataManager dm1 = new DataManager("localhost", "project", "root", "");
        public FrmLogin()
        {
            InitializeComponent();
        }//ef

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //hide the password chars
            txtPassword.UseSystemPasswordChar = true;
        }//ef
        
        void BtnLoginClick(object sender, EventArgs e)
        {
        	//take username and password from textboxes
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            //return error if the user doesn't input username/password
            if (username == "" || password == "")
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Invalid username or password");
                return;
            }//endif

            //sql statement for retrieving the inputted username and password
            string sql = "SELECT * FROM employees ";
            sql += "WHERE username = 'p1' AND password = 'p2'";
            sql = sql.Replace("p1", username);
            sql = sql.Replace("p2", password);

            DataTable resultTable = dm1.GetDataTable(sql);

            if (resultTable.Rows.Count > 0)
            //if the there is a result from query, then we login in to the main page
            {
            	string firstName = resultTable.Rows[0][1].ToString();
            	string lastName	 = resultTable.Rows[0][2].ToString();
            	string role		 = resultTable.Rows[0][5].ToString();
            	
            	User loginUser	= new User(firstName, lastName, role);
            	Global.user 	= loginUser;
            	
            	MainForm m1 = new MainForm();
            	m1.ShowDialog();
            }//endif
            else
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Invalid username or password");
                return;
            }//endelse
        }//ef
        
        void LblCreateUserClick(object sender, EventArgs e)
        {
        	FrmRegister registerForm = new FrmRegister();
        	registerForm.Show();
        	
        }//ef
    }//ec
}//en