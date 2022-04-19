/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 08-Feb-22
 * Time: 10:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace termProject
{
	/// <summary>
	/// Description of FrmReport.
	/// </summary>
	public partial class FrmReport : Form
	{
        DataManager dm1 = new DataManager("localhost", "project", "root", "");
        
		public FrmReport()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}//econ
		
		
		private void TotalSaleByDate()
		{
			//clear chart first
			chart1.Series["Sales"].Points.Clear();
			
			//get string date from datepickers
        	string fromDate = dtpTimeIntervalFrom.Value.ToString("yyyy/MM/dd");
        	string toDate 	= dtpTimeIntervalTo.Value.ToString("yyyy/MM/dd");
			
			string sql = "SELECT orderDate, SUM(total) FROM orders " +
						 "WHERE orderDate >= 'd1' AND orderDate <= 'd2'" +
                         "GROUP BY orderDate";
			sql = sql.Replace("d1", fromDate);
            sql = sql.Replace("d2", toDate);
            
            DataTable resultTable = dm1.GetDataTable(sql);

            for(int i = 1; i <= resultTable.Rows.Count; i++)
            {
                DateTime orderDateTime = Convert.ToDateTime(resultTable.Rows[i-1][0].ToString());
                string orderDate = orderDateTime.ToString("dd-MMM");

                double total = double.Parse(resultTable.Rows[i-1][1].ToString());

                chart1.Series["Sales"].Points.AddXY(orderDate, total);

            }//eloop
            
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
		}//ef
		

		private void couponsChart()
		{
			//clear chart first
			chart3.Series["Coupons"].Points.Clear();
			
			//get string date from datepickers
        	string fromDate = dtpTimeIntervalFrom.Value.ToString("yyyy/MM/dd");
        	string toDate 	= dtpTimeIntervalTo.Value.ToString("yyyy/MM/dd");
        	
        	// SELECT c.couponCode,COUNT(*) FROM couponsuse AS c , orders AS o 
        	// WHERE c.orderId = o.orderId 
        	// AND o.orderDate >= '2022-03-26' AND o.orderDate <= '2022-04-26';
			
			string sql = 	"SELECT c.couponCode,COUNT(*) FROM couponsuse AS c , orders AS o " +
							"WHERE c.orderId = o.orderId " +
							"AND o.orderDate >= 'd1' AND o.orderDate <= 'd2' " +
							"GROUP BY c.couponCode";
			
            sql = sql.Replace("d1", fromDate);
            sql = sql.Replace("d2", toDate);
            
            DataTable resultTable = dm1.GetDataTable(sql);

            for(int i = 1; i <= resultTable.Rows.Count; i++)
            {  
                string couponCode = resultTable.Rows[i-1][0].ToString();

                int qty = int.Parse(resultTable.Rows[i-1][1].ToString());

                chart3.Series["Coupons"].Points.AddXY(couponCode, qty);

            }//eloop
            chart3.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart3.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart3.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart3.ChartAreas[0].AxisX.MinorGrid.Enabled = false;

		}//ef
		
		private void BestSeller()
		{
			//clear chart first
			chart2.Series["TopProduct"].Points.Clear();
			
			//get string date from datepickers
        	string fromDate = dtpTimeIntervalFrom.Value.ToString("yyyy/MM/dd");
        	string toDate 	= dtpTimeIntervalTo.Value.ToString("yyyy/MM/dd");
			
			string sql = "SELECT p.productName, SUM(od.quantity) FROM orderdetails " +
						 " AS od, products AS p, orders AS o " +
                         " WHERE od.productId = p.productId AND od.orderId = o.orderId " +
						 " AND (o.orderDate >= 'd1' AND o.orderDate <= 'd2') " +
				      	 " GROUP BY p.productName " +
						 " ORDER BY SUM(od.quantity) " +
						 " LIMIT 5";
			
            sql = sql.Replace("d1", fromDate);
            sql = sql.Replace("d2", toDate);
            
            DataTable resultTable = dm1.GetDataTable(sql);

            for(int i = 1; i <= resultTable.Rows.Count; i++)
            {  
                string productName = resultTable.Rows[i-1][0].ToString();

                int qty = int.Parse(resultTable.Rows[i-1][1].ToString());

                chart2.Series["TopProduct"].Points.AddXY(productName, qty);

            }//eloop
            
            chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart2.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart2.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
		}//ef
		
		private void showTopCustomer()
        {
            listViewTopCustomer.Items.Clear();

            //get string date from datepickers
        	string fromDate = dtpTimeIntervalFrom.Value.ToString("yyyy/MM/dd");
        	string toDate 	= dtpTimeIntervalTo.Value.ToString("yyyy/MM/dd");
        	
        	
            string sql = "SELECT CONCAT(c.firstName, ' ', c.lastName) as customername, SUM(o.total) FROM customers c " +
                         "JOIN orders o ON c.customerId = o.customerId " +
                         "WHERE (o.orderDate >= 'd1' AND o.orderDate <= 'd2') AND c.customerId != 0 " +
                         "GROUP BY customername " +
            			 "ORDER BY SUM(o.total) DESC";
            sql = sql.Replace("d1", fromDate);
            sql = sql.Replace("d2", toDate);

            DataTable result = dm1.GetDataTable(sql);
            
            int rank = 1;
            foreach (DataRow row in result.Rows)
            {
            	//create a variable to convert to string to make thousand separator
            	double total = int.Parse(row[1].ToString());
            	
            	ListViewItem newRow = new ListViewItem(rank.ToString());
                newRow.SubItems.Add(row[0].ToString());
                newRow.SubItems.Add(total.ToString("#,##0") + ".-");

                listViewTopCustomer.Items.Add(newRow);

                rank += 1;
            }//end loop
        }//ef
		
		
		private string showEarning()
        { 
            // SELECT SUM(total) FROM orders WHERE orderStatus = 'Complete' AND orderDate >= '2022-02-23' AND orderDate<= '2022-03-01';
            string fromDate = dtpTimeIntervalFrom.Value.ToString("yyyy/MM/dd");
            string toDate     = dtpTimeIntervalTo.Value.ToString("yyyy/MM/dd");
            string sql =     "SELECT SUM(total) FROM orders " +
            	"WHERE orderStatus = 'Complete' " +
            	"AND orderDate >= 'd1' AND orderDate<= 'd2'" ;

            sql = sql.Replace("d1", fromDate);
            sql = sql.Replace("d2", toDate);

            DataTable resultTable = dm1.GetDataTable(sql);
            //return resultTable.Rows[0][0].ToString();
            //ความว่างเปล่าคือสิ่งที่น่ากลัวที่สุด ;-;
            if (resultTable.Rows[0][0].ToString() == "")
            {
            	return "0";
            }//eif
            else
            {
            	double earning = double.Parse(resultTable.Rows[0][0].ToString());
            	return earning.ToString("#0,###");
            }//eelse
        
		}//ef
		
		private string showOrder()
		{
			string fromDate = dtpTimeIntervalFrom.Value.ToString("yyyy/MM/dd");
        	string toDate     = dtpTimeIntervalTo.Value.ToString("yyyy/MM/dd");
        	
        	//SELECT COUNT(*) FROM orders WHERE orderStatus = "Complete";
			string sql = "SELECT COUNT(*) FROM orders "
				+ "WHERE orderStatus = 'Complete'" +
				"AND orderDate >= 'd1' AND orderDate<= 'd2'";
			
			sql = sql.Replace("d1", fromDate);
            sql = sql.Replace("d2", toDate);
            
			DataTable resultTable = dm1.GetDataTable(sql); 
			return resultTable.Rows[0][0].ToString();
			
		}//ef
		
		private string showInventoryunsafe()
		{
        	//SELECT COUNT(*) FROM products WHERE quantityInStock <= '5' 
        	string sql = "SELECT COUNT(*) FROM products WHERE quantityInStock <= '5' ";
        	
        	DataTable resultTable = dm1.GetDataTable(sql); 
			return resultTable.Rows[0][0].ToString();
		
		}//ef
		

		
		
		private void setDatePickerFormat()
		{
			dtpTimeIntervalFrom.Format = DateTimePickerFormat.Custom;
			dtpTimeIntervalFrom.CustomFormat = "dd-MMM-yyyy";
			dtpTimeIntervalTo.Format = DateTimePickerFormat.Custom;
			dtpTimeIntervalTo.CustomFormat = "dd-MMM-yyyy";
		}//ef
		
		
		void FrmReportLoad(object sender, EventArgs e)
		{
			//set format for datepickers
			setDatePickerFormat();
			
			//get data for charts
			showTopCustomer();
			TotalSaleByDate();
			BestSeller();
			couponsChart();
			lblEarning.Text = showEarning();
			lblOrder.Text = showOrder();
			lblInventoryUnsafe.Text = showInventoryunsafe();
        }//ef
		
		
		void DtpTimeIntervalFromValueChanged(object sender, EventArgs e)
		{
			showTopCustomer();
			TotalSaleByDate();
			BestSeller();
			couponsChart();
			lblEarning.Text = showEarning();
			lblOrder.Text = showOrder();
			lblInventoryUnsafe.Text = showInventoryunsafe();
		}//ef
		
		void DtpTimeIntervalToValueChanged(object sender, EventArgs e)
		{
			showTopCustomer();
			TotalSaleByDate();
			BestSeller();
			couponsChart();
			lblEarning.Text = showEarning();
			lblOrder.Text = showOrder();
			lblInventoryUnsafe.Text = showInventoryunsafe();
		}//ef
	}//ec
}//en
