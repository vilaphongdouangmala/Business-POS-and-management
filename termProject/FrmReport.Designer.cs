/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 08-Feb-22
 * Time: 10:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace termProject
{
	partial class FrmReport
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReport));
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel7 = new System.Windows.Forms.Panel();
			this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label5 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.dtpTimeIntervalTo = new System.Windows.Forms.DateTimePicker();
			this.dtpTimeIntervalFrom = new System.Windows.Forms.DateTimePicker();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblInventoryUnsafe = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblOrder = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.listViewTopCustomer = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblEarning = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel7);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.dtpTimeIntervalTo);
			this.groupBox1.Controls.Add(this.dtpTimeIntervalFrom);
			this.groupBox1.Controls.Add(this.panel6);
			this.groupBox1.Controls.Add(this.panel2);
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Controls.Add(this.panel5);
			this.groupBox1.Controls.Add(this.panel4);
			this.groupBox1.Controls.Add(this.panel3);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(13, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(860, 507);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Report";
			// 
			// panel7
			// 
			this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
			this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel7.Controls.Add(this.chart3);
			this.panel7.Controls.Add(this.label5);
			this.panel7.Location = new System.Drawing.Point(569, 295);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(285, 206);
			this.panel7.TabIndex = 24;
			// 
			// chart3
			// 
			this.chart3.BackColor = System.Drawing.Color.Transparent;
			chartArea1.Name = "ChartArea1";
			this.chart3.ChartAreas.Add(chartArea1);
			legend1.Enabled = false;
			legend1.Name = "Legend1";
			this.chart3.Legends.Add(legend1);
			this.chart3.Location = new System.Drawing.Point(-11, 34);
			this.chart3.Name = "chart3";
			series1.ChartArea = "ChartArea1";
			series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F);
			series1.Legend = "Legend1";
			series1.Name = "Coupons";
			this.chart3.Series.Add(series1);
			this.chart3.Size = new System.Drawing.Size(293, 181);
			this.chart3.TabIndex = 24;
			this.chart3.Text = "chart3";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label5.Location = new System.Drawing.Point(6, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(145, 23);
			this.label5.TabIndex = 23;
			this.label5.Text = "Coupons";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label13.Location = new System.Drawing.Point(282, 15);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(50, 16);
			this.label13.TabIndex = 26;
			this.label13.Text = "To:";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label12.Location = new System.Drawing.Point(134, 14);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(50, 16);
			this.label12.TabIndex = 25;
			this.label12.Text = "From:";
			// 
			// dtpTimeIntervalTo
			// 
			this.dtpTimeIntervalTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			this.dtpTimeIntervalTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpTimeIntervalTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpTimeIntervalTo.Location = new System.Drawing.Point(286, 31);
			this.dtpTimeIntervalTo.Name = "dtpTimeIntervalTo";
			this.dtpTimeIntervalTo.Size = new System.Drawing.Size(122, 22);
			this.dtpTimeIntervalTo.TabIndex = 25;
			this.dtpTimeIntervalTo.ValueChanged += new System.EventHandler(this.DtpTimeIntervalToValueChanged);
			// 
			// dtpTimeIntervalFrom
			// 
			this.dtpTimeIntervalFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			this.dtpTimeIntervalFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpTimeIntervalFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpTimeIntervalFrom.Location = new System.Drawing.Point(136, 31);
			this.dtpTimeIntervalFrom.Name = "dtpTimeIntervalFrom";
			this.dtpTimeIntervalFrom.Size = new System.Drawing.Size(122, 22);
			this.dtpTimeIntervalFrom.TabIndex = 24;
			this.dtpTimeIntervalFrom.ValueChanged += new System.EventHandler(this.DtpTimeIntervalFromValueChanged);
			// 
			// panel6
			// 
			this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
			this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel6.Controls.Add(this.label11);
			this.panel6.Controls.Add(this.chart2);
			this.panel6.Location = new System.Drawing.Point(569, 59);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(285, 230);
			this.panel6.TabIndex = 21;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.White;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label11.Location = new System.Drawing.Point(6, 11);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(145, 23);
			this.label11.TabIndex = 23;
			this.label11.Text = "Best Sellers";
			// 
			// chart2
			// 
			this.chart2.BackColor = System.Drawing.Color.Transparent;
			this.chart2.BorderlineColor = System.Drawing.Color.Transparent;
			chartArea2.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea2);
			legend2.Enabled = false;
			legend2.Name = "Legend1";
			this.chart2.Legends.Add(legend2);
			this.chart2.Location = new System.Drawing.Point(-11, 30);
			this.chart2.Name = "chart2";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
			series2.Color = System.Drawing.Color.DarkOrange;
			series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F);
			series2.Legend = "Legend1";
			series2.Name = "TopProduct";
			this.chart2.Series.Add(series2);
			this.chart2.Size = new System.Drawing.Size(296, 208);
			this.chart2.TabIndex = 0;
			this.chart2.Text = "chart2";
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.lblInventoryUnsafe);
			this.panel2.Location = new System.Drawing.Point(6, 355);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(124, 146);
			this.panel2.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label3.Location = new System.Drawing.Point(6, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 24);
			this.label3.TabIndex = 17;
			this.label3.Text = "Items";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label4.Location = new System.Drawing.Point(6, 11);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 39);
			this.label4.TabIndex = 13;
			this.label4.Text = "Inventory Unsafe";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblInventoryUnsafe
			// 
			this.lblInventoryUnsafe.BackColor = System.Drawing.Color.White;
			this.lblInventoryUnsafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lblInventoryUnsafe.Location = new System.Drawing.Point(3, 36);
			this.lblInventoryUnsafe.Name = "lblInventoryUnsafe";
			this.lblInventoryUnsafe.Size = new System.Drawing.Size(115, 85);
			this.lblInventoryUnsafe.TabIndex = 14;
			this.lblInventoryUnsafe.Text = "00";
			this.lblInventoryUnsafe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.lblOrder);
			this.panel1.Location = new System.Drawing.Point(6, 207);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(124, 142);
			this.panel1.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label8.Location = new System.Drawing.Point(6, 111);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 24);
			this.label8.TabIndex = 16;
			this.label8.Text = "Orders";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label1.Location = new System.Drawing.Point(0, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 23);
			this.label1.TabIndex = 13;
			this.label1.Text = "Order";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblOrder
			// 
			this.lblOrder.BackColor = System.Drawing.Color.White;
			this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lblOrder.Location = new System.Drawing.Point(3, 34);
			this.lblOrder.Name = "lblOrder";
			this.lblOrder.Size = new System.Drawing.Size(118, 85);
			this.lblOrder.TabIndex = 14;
			this.lblOrder.Text = "00";
			this.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel5
			// 
			this.panel5.AutoScroll = true;
			this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
			this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel5.Controls.Add(this.label6);
			this.panel5.Controls.Add(this.listViewTopCustomer);
			this.panel5.Location = new System.Drawing.Point(136, 295);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(427, 206);
			this.panel5.TabIndex = 20;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label6.Location = new System.Drawing.Point(10, 8);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(145, 23);
			this.label6.TabIndex = 21;
			this.label6.Text = "Top Customers";
			// 
			// listViewTopCustomer
			// 
			this.listViewTopCustomer.BackColor = System.Drawing.Color.White;
			this.listViewTopCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listViewTopCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3});
			this.listViewTopCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.listViewTopCustomer.Location = new System.Drawing.Point(10, 34);
			this.listViewTopCustomer.Name = "listViewTopCustomer";
			this.listViewTopCustomer.Size = new System.Drawing.Size(406, 169);
			this.listViewTopCustomer.TabIndex = 20;
			this.listViewTopCustomer.UseCompatibleStateImageBehavior = false;
			this.listViewTopCustomer.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Rank";
			this.columnHeader1.Width = 48;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Customer name";
			this.columnHeader2.Width = 200;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Total sale value";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader3.Width = 130;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.chart1);
			this.panel4.Location = new System.Drawing.Point(136, 59);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(427, 230);
			this.panel4.TabIndex = 19;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.White;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label10.Location = new System.Drawing.Point(10, 33);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(41, 16);
			this.label10.TabIndex = 16;
			this.label10.Text = "Baht";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label9.Location = new System.Drawing.Point(10, 5);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(145, 23);
			this.label9.TabIndex = 22;
			this.label9.Text = "Sale Volume";
			// 
			// chart1
			// 
			this.chart1.BackColor = System.Drawing.Color.Transparent;
			chartArea3.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea3);
			legend3.Enabled = false;
			legend3.Name = "Legend1";
			this.chart1.Legends.Add(legend3);
			this.chart1.Location = new System.Drawing.Point(-6, 46);
			this.chart1.Name = "chart1";
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series3.Color = System.Drawing.Color.Maroon;
			series3.LabelBorderWidth = 0;
			series3.Legend = "Legend1";
			series3.MarkerBorderWidth = 3;
			series3.MarkerColor = System.Drawing.Color.Orange;
			series3.MarkerSize = 6;
			series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
			series3.Name = "Sales";
			series3.ShadowColor = System.Drawing.Color.White;
			series3.YValuesPerPoint = 6;
			this.chart1.Series.Add(series3);
			this.chart1.Size = new System.Drawing.Size(431, 189);
			this.chart1.TabIndex = 18;
			this.chart1.Text = "chart1";
			// 
			// panel3
			// 
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.lblEarning);
			this.panel3.Location = new System.Drawing.Point(6, 59);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(124, 142);
			this.panel3.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label7.Location = new System.Drawing.Point(6, 112);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(112, 16);
			this.label7.TabIndex = 15;
			this.label7.Text = "Baht";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label2.Location = new System.Drawing.Point(0, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "Earning";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblEarning
			// 
			this.lblEarning.BackColor = System.Drawing.Color.White;
			this.lblEarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lblEarning.Location = new System.Drawing.Point(3, 33);
			this.lblEarning.Name = "lblEarning";
			this.lblEarning.Size = new System.Drawing.Size(118, 85);
			this.lblEarning.TabIndex = 14;
			this.lblEarning.Text = "00";
			this.lblEarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 531);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FrmReport";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "FrmReport";
			this.Load += new System.EventHandler(this.FrmReportLoad);
			this.groupBox1.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
			this.panel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblInventoryUnsafe;
		private System.Windows.Forms.Label lblOrder;
		private System.Windows.Forms.Label lblEarning;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DateTimePicker dtpTimeIntervalTo;
		private System.Windows.Forms.DateTimePicker dtpTimeIntervalFrom;
		private System.Windows.Forms.ListView listViewTopCustomer;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.GroupBox groupBox1;
		
	}
}
