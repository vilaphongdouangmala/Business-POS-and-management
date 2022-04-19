/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 25-Mar-22
 * Time: 3:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace termProject
{
	partial class FrmOrders
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrders));
			this.label22 = new System.Windows.Forms.Label();
			this.btnCustSearch = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.listViewOrder = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label12 = new System.Windows.Forms.Label();
			this.btnUpdate = new termProject.RoundedButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dtpShippingDate = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbOrderStatus = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblOrderId = new System.Windows.Forms.Label();
			this.lblCustomerName = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.listViewToBeShipped = new System.Windows.Forms.ListView();
			this.OrderID = new System.Windows.Forms.ColumnHeader();
			this.CustomerName = new System.Windows.Forms.ColumnHeader();
			this.Address = new System.Windows.Forms.ColumnHeader();
			this.lblTodayDate = new System.Windows.Forms.Label();
			this.dtpFilter = new System.Windows.Forms.DateTimePicker();
			this.btnRefresh = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// label22
			// 
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label22.Location = new System.Drawing.Point(12, 14);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(163, 23);
			this.label22.TabIndex = 89;
			this.label22.Text = "Order List";
			// 
			// btnCustSearch
			// 
			this.btnCustSearch.BackColor = System.Drawing.Color.White;
			this.btnCustSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustSearch.BackgroundImage")));
			this.btnCustSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCustSearch.FlatAppearance.BorderSize = 0;
			this.btnCustSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustSearch.Location = new System.Drawing.Point(505, 56);
			this.btnCustSearch.Margin = new System.Windows.Forms.Padding(4);
			this.btnCustSearch.Name = "btnCustSearch";
			this.btnCustSearch.Size = new System.Drawing.Size(23, 20);
			this.btnCustSearch.TabIndex = 94;
			this.btnCustSearch.UseVisualStyleBackColor = false;
			// 
			// txtSearch
			// 
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtSearch.Location = new System.Drawing.Point(29, 56);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(455, 19);
			this.txtSearch.TabIndex = 91;
			this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearchTextChanged);
			// 
			// listViewOrder
			// 
			this.listViewOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader11,
									this.columnHeader12});
			this.listViewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listViewOrder.FullRowSelect = true;
			this.listViewOrder.Location = new System.Drawing.Point(29, 98);
			this.listViewOrder.Margin = new System.Windows.Forms.Padding(2);
			this.listViewOrder.MultiSelect = false;
			this.listViewOrder.Name = "listViewOrder";
			this.listViewOrder.ShowItemToolTips = true;
			this.listViewOrder.Size = new System.Drawing.Size(797, 206);
			this.listViewOrder.TabIndex = 90;
			this.listViewOrder.UseCompatibleStateImageBehavior = false;
			this.listViewOrder.View = System.Windows.Forms.View.Details;
			this.listViewOrder.SelectedIndexChanged += new System.EventHandler(this.ListViewOrderSelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Order ID";
			this.columnHeader1.Width = 73;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Customer name";
			this.columnHeader2.Width = 152;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Order Date";
			this.columnHeader3.Width = 107;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Shipping Date";
			this.columnHeader4.Width = 114;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Order Status";
			this.columnHeader5.Width = 109;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Payment Type";
			this.columnHeader11.Width = 119;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Total";
			this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader12.Width = 107;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(15, 89);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(826, 241);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 92;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(15, 51);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(522, 32);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 93;
			this.pictureBox3.TabStop = false;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.White;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(34, 343);
			this.label12.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(245, 22);
			this.label12.TabIndex = 117;
			this.label12.Text = "Update Order Information";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.Maroon;
			this.btnUpdate.BackgroundColor = System.Drawing.Color.Maroon;
			this.btnUpdate.BorderColor = System.Drawing.Color.Tomato;
			this.btnUpdate.BorderRadius = 15;
			this.btnUpdate.BorderSize = 0;
			this.btnUpdate.FlatAppearance.BorderSize = 0;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.Location = new System.Drawing.Point(411, 479);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(73, 30);
			this.btnUpdate.TabIndex = 109;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.TextColor = System.Drawing.Color.White;
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(15, 338);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(481, 180);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 116;
			this.pictureBox1.TabStop = false;
			// 
			// dtpShippingDate
			// 
			this.dtpShippingDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			this.dtpShippingDate.CalendarTitleBackColor = System.Drawing.Color.Maroon;
			this.dtpShippingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpShippingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpShippingDate.Location = new System.Drawing.Point(254, 456);
			this.dtpShippingDate.Margin = new System.Windows.Forms.Padding(4);
			this.dtpShippingDate.Name = "dtpShippingDate";
			this.dtpShippingDate.Size = new System.Drawing.Size(137, 22);
			this.dtpShippingDate.TabIndex = 119;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(254, 435);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 16);
			this.label2.TabIndex = 118;
			this.label2.Text = "Shipping date:";
			// 
			// cmbOrderStatus
			// 
			this.cmbOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbOrderStatus.FormattingEnabled = true;
			this.cmbOrderStatus.Location = new System.Drawing.Point(53, 454);
			this.cmbOrderStatus.Name = "cmbOrderStatus";
			this.cmbOrderStatus.Size = new System.Drawing.Size(137, 24);
			this.cmbOrderStatus.TabIndex = 120;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(53, 435);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 16);
			this.label1.TabIndex = 121;
			this.label1.Text = "Order Status:";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(53, 379);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 16);
			this.label3.TabIndex = 122;
			this.label3.Text = "Order ID:";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(254, 379);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 16);
			this.label4.TabIndex = 123;
			this.label4.Text = "Customer name:";
			// 
			// lblOrderId
			// 
			this.lblOrderId.BackColor = System.Drawing.Color.White;
			this.lblOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOrderId.Location = new System.Drawing.Point(53, 402);
			this.lblOrderId.Name = "lblOrderId";
			this.lblOrderId.Size = new System.Drawing.Size(137, 16);
			this.lblOrderId.TabIndex = 124;
			this.lblOrderId.Text = "<ID>";
			// 
			// lblCustomerName
			// 
			this.lblCustomerName.BackColor = System.Drawing.Color.White;
			this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomerName.Location = new System.Drawing.Point(254, 402);
			this.lblCustomerName.Name = "lblCustomerName";
			this.lblCustomerName.Size = new System.Drawing.Size(170, 16);
			this.lblCustomerName.TabIndex = 125;
			this.lblCustomerName.Text = "<name>";
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(504, 338);
			this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(337, 180);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 126;
			this.pictureBox4.TabStop = false;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(517, 343);
			this.label7.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(159, 22);
			this.label7.TabIndex = 127;
			this.label7.Text = "To be shipped today:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// listViewToBeShipped
			// 
			this.listViewToBeShipped.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listViewToBeShipped.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.OrderID,
									this.CustomerName,
									this.Address});
			this.listViewToBeShipped.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.listViewToBeShipped.FullRowSelect = true;
			this.listViewToBeShipped.Location = new System.Drawing.Point(517, 372);
			this.listViewToBeShipped.Margin = new System.Windows.Forms.Padding(2);
			this.listViewToBeShipped.MultiSelect = false;
			this.listViewToBeShipped.Name = "listViewToBeShipped";
			this.listViewToBeShipped.ShowItemToolTips = true;
			this.listViewToBeShipped.Size = new System.Drawing.Size(299, 137);
			this.listViewToBeShipped.TabIndex = 128;
			this.listViewToBeShipped.UseCompatibleStateImageBehavior = false;
			this.listViewToBeShipped.View = System.Windows.Forms.View.Details;
			// 
			// OrderID
			// 
			this.OrderID.Text = "Order ID";
			this.OrderID.Width = 61;
			// 
			// CustomerName
			// 
			this.CustomerName.Text = "Customer name";
			this.CustomerName.Width = 129;
			// 
			// Address
			// 
			this.Address.Text = "Address";
			this.Address.Width = 109;
			// 
			// lblTodayDate
			// 
			this.lblTodayDate.BackColor = System.Drawing.Color.White;
			this.lblTodayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblTodayDate.Location = new System.Drawing.Point(678, 344);
			this.lblTodayDate.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.lblTodayDate.Name = "lblTodayDate";
			this.lblTodayDate.Size = new System.Drawing.Size(148, 22);
			this.lblTodayDate.TabIndex = 129;
			this.lblTodayDate.Text = "<today date>";
			this.lblTodayDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpFilter
			// 
			this.dtpFilter.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			this.dtpFilter.CalendarTitleBackColor = System.Drawing.Color.Maroon;
			this.dtpFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.dtpFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFilter.Location = new System.Drawing.Point(647, 54);
			this.dtpFilter.Margin = new System.Windows.Forms.Padding(4);
			this.dtpFilter.Name = "dtpFilter";
			this.dtpFilter.Size = new System.Drawing.Size(157, 24);
			this.dtpFilter.TabIndex = 130;
			this.dtpFilter.ValueChanged += new System.EventHandler(this.DtpFilterValueChanged);
			// 
			// btnRefresh
			// 
			this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
			this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
			this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnRefresh.FlatAppearance.BorderSize = 0;
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.Location = new System.Drawing.Point(811, 52);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(30, 27);
			this.btnRefresh.TabIndex = 131;
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
			// 
			// FrmOrders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 531);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.dtpFilter);
			this.Controls.Add(this.lblTodayDate);
			this.Controls.Add(this.listViewToBeShipped);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.lblCustomerName);
			this.Controls.Add(this.lblOrderId);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbOrderStatus);
			this.Controls.Add(this.dtpShippingDate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnCustSearch);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.listViewOrder);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.label22);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FrmOrders";
			this.Text = "FrmOrders";
			this.Load += new System.EventHandler(this.FrmOrdersLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.DateTimePicker dtpFilter;
		private System.Windows.Forms.ComboBox cmbOrderStatus;
		private termProject.RoundedButton btnUpdate;
		private System.Windows.Forms.Label lblCustomerName;
		private System.Windows.Forms.Label lblOrderId;
		private System.Windows.Forms.Label lblTodayDate;
		private System.Windows.Forms.ColumnHeader Address;
		private System.Windows.Forms.ColumnHeader CustomerName;
		private System.Windows.Forms.ColumnHeader OrderID;
		private System.Windows.Forms.ListView listViewToBeShipped;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtpShippingDate;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.ListView listViewOrder;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Button btnCustSearch;
		private System.Windows.Forms.Label label22;
	}
}
