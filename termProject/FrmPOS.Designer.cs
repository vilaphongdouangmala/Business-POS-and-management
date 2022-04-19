/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 17-Feb-22
 * Time: 7:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace termProject
{
	partial class FrmPOS
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPOS));
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.lblFreeItem = new System.Windows.Forms.Label();
			this.cmbShipping = new System.Windows.Forms.ComboBox();
			this.dtpShippingDate = new System.Windows.Forms.DateTimePicker();
			this.label17 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.cmbPaymentType = new System.Windows.Forms.ComboBox();
			this.listViewOrder = new System.Windows.Forms.ListView();
			this.columnItem = new System.Windows.Forms.ColumnHeader();
			this.columnQty = new System.Windows.Forms.ColumnHeader();
			this.columnPrice = new System.Windows.Forms.ColumnHeader();
			this.columnTotal = new System.Windows.Forms.ColumnHeader();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnCustSearch = new System.Windows.Forms.Button();
			this.txtProductSearch = new System.Windows.Forms.TextBox();
			this.lblGrandTotal = new System.Windows.Forms.Label();
			this.lblDiscount = new System.Windows.Forms.Label();
			this.lblSubtotal = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblShipping = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblPaymentMethod = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.btnOrderCheckout = new termProject.SemiRoundedButton();
			this.btnApplyDiscount = new termProject.RoundedButton();
			this.lblOrderId = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.lblCustomerId = new System.Windows.Forms.Label();
			this.lblCustomerName = new System.Windows.Forms.Label();
			this.lblCustomerPhone = new System.Windows.Forms.Label();
			this.lblCustomerCity = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.flpProductList = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.cmbDiscount = new System.Windows.Forms.ComboBox();
			this.btnDelete = new termProject.RoundedButton();
			this.cmbCustName = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.White;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(30, 489);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(106, 16);
			this.label14.TabIndex = 67;
			this.label14.Text = "Discount code:";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.White;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(30, 431);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(129, 22);
			this.label15.TabIndex = 71;
			this.label15.Text = "Shipping:";
			// 
			// lblFreeItem
			// 
			this.lblFreeItem.BackColor = System.Drawing.Color.White;
			this.lblFreeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblFreeItem.Location = new System.Drawing.Point(116, 341);
			this.lblFreeItem.Name = "lblFreeItem";
			this.lblFreeItem.Size = new System.Drawing.Size(165, 22);
			this.lblFreeItem.TabIndex = 76;
			this.lblFreeItem.Text = "-";
			// 
			// cmbShipping
			// 
			this.cmbShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbShipping.FormattingEnabled = true;
			this.cmbShipping.Items.AddRange(new object[] {
									"Yes",
									"No"});
			this.cmbShipping.Location = new System.Drawing.Point(30, 450);
			this.cmbShipping.Margin = new System.Windows.Forms.Padding(4);
			this.cmbShipping.Name = "cmbShipping";
			this.cmbShipping.Size = new System.Drawing.Size(158, 23);
			this.cmbShipping.TabIndex = 72;
			this.cmbShipping.TextChanged += new System.EventHandler(this.CmbShippingTextChanged);
			// 
			// dtpShippingDate
			// 
			this.dtpShippingDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			this.dtpShippingDate.CalendarTitleBackColor = System.Drawing.Color.Maroon;
			this.dtpShippingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpShippingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpShippingDate.Location = new System.Drawing.Point(230, 450);
			this.dtpShippingDate.Margin = new System.Windows.Forms.Padding(4);
			this.dtpShippingDate.Name = "dtpShippingDate";
			this.dtpShippingDate.Size = new System.Drawing.Size(152, 22);
			this.dtpShippingDate.TabIndex = 77;
			this.dtpShippingDate.ValueChanged += new System.EventHandler(this.DtpShippingDateValueChanged);
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.White;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(30, 344);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(69, 22);
			this.label17.TabIndex = 75;
			this.label17.Text = "Free item:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(230, 429);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 16);
			this.label2.TabIndex = 69;
			this.label2.Text = "Shipping date:";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.White;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(230, 381);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(165, 15);
			this.label16.TabIndex = 73;
			this.label16.Text = "Payment type:";
			// 
			// cmbPaymentType
			// 
			this.cmbPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbPaymentType.FormattingEnabled = true;
			this.cmbPaymentType.Items.AddRange(new object[] {
									"Cash",
									"Credit Card",
									"Bank Transfer"});
			this.cmbPaymentType.Location = new System.Drawing.Point(230, 402);
			this.cmbPaymentType.Margin = new System.Windows.Forms.Padding(4);
			this.cmbPaymentType.Name = "cmbPaymentType";
			this.cmbPaymentType.Size = new System.Drawing.Size(152, 21);
			this.cmbPaymentType.TabIndex = 74;
			this.cmbPaymentType.TextChanged += new System.EventHandler(this.CmbPaymentTypeTextChanged);
			// 
			// listViewOrder
			// 
			this.listViewOrder.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.listViewOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnItem,
									this.columnQty,
									this.columnPrice,
									this.columnTotal});
			this.listViewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listViewOrder.FullRowSelect = true;
			this.listViewOrder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewOrder.Location = new System.Drawing.Point(597, 51);
			this.listViewOrder.Margin = new System.Windows.Forms.Padding(4);
			this.listViewOrder.MultiSelect = false;
			this.listViewOrder.Name = "listViewOrder";
			this.listViewOrder.Size = new System.Drawing.Size(264, 148);
			this.listViewOrder.TabIndex = 34;
			this.listViewOrder.UseCompatibleStateImageBehavior = false;
			this.listViewOrder.View = System.Windows.Forms.View.Details;
			// 
			// columnItem
			// 
			this.columnItem.Text = "ITEM";
			this.columnItem.Width = 108;
			// 
			// columnQty
			// 
			this.columnQty.Text = "QTY";
			this.columnQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnQty.Width = 40;
			// 
			// columnPrice
			// 
			this.columnPrice.Text = "PRICE";
			this.columnPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnPrice.Width = 56;
			// 
			// columnTotal
			// 
			this.columnTotal.Text = "TOTAL";
			this.columnTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(612, 382);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(237, 77);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 43;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(587, 11);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(284, 491);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 33;
			this.pictureBox1.TabStop = false;
			// 
			// btnCustSearch
			// 
			this.btnCustSearch.BackColor = System.Drawing.Color.White;
			this.btnCustSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustSearch.BackgroundImage")));
			this.btnCustSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCustSearch.FlatAppearance.BorderSize = 0;
			this.btnCustSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustSearch.Location = new System.Drawing.Point(551, 17);
			this.btnCustSearch.Margin = new System.Windows.Forms.Padding(4);
			this.btnCustSearch.Name = "btnCustSearch";
			this.btnCustSearch.Size = new System.Drawing.Size(23, 20);
			this.btnCustSearch.TabIndex = 55;
			this.btnCustSearch.UseVisualStyleBackColor = false;
			// 
			// txtProductSearch
			// 
			this.txtProductSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtProductSearch.Location = new System.Drawing.Point(248, 16);
			this.txtProductSearch.Name = "txtProductSearch";
			this.txtProductSearch.Size = new System.Drawing.Size(296, 19);
			this.txtProductSearch.TabIndex = 54;
			this.txtProductSearch.TextChanged += new System.EventHandler(this.TxtProductSearchTextChanged);
			// 
			// lblGrandTotal
			// 
			this.lblGrandTotal.BackColor = System.Drawing.SystemColors.Control;
			this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGrandTotal.ForeColor = System.Drawing.Color.Black;
			this.lblGrandTotal.Location = new System.Drawing.Point(709, 431);
			this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblGrandTotal.Name = "lblGrandTotal";
			this.lblGrandTotal.Size = new System.Drawing.Size(112, 17);
			this.lblGrandTotal.TabIndex = 51;
			this.lblGrandTotal.Text = "0";
			this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// lblDiscount
			// 
			this.lblDiscount.BackColor = System.Drawing.SystemColors.Control;
			this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDiscount.ForeColor = System.Drawing.Color.Black;
			this.lblDiscount.Location = new System.Drawing.Point(709, 410);
			this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDiscount.Name = "lblDiscount";
			this.lblDiscount.Size = new System.Drawing.Size(112, 17);
			this.lblDiscount.TabIndex = 50;
			this.lblDiscount.Text = "0";
			this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.BackColor = System.Drawing.SystemColors.Control;
			this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtotal.ForeColor = System.Drawing.Color.Black;
			this.lblSubtotal.Location = new System.Drawing.Point(709, 388);
			this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(112, 17);
			this.lblSubtotal.TabIndex = 49;
			this.lblSubtotal.Text = "0";
			this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.SystemColors.Control;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(634, 431);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(90, 22);
			this.label11.TabIndex = 46;
			this.label11.Text = "Grand Total";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.SystemColors.Control;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(634, 410);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 21);
			this.label10.TabIndex = 45;
			this.label10.Text = "Discount";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.SystemColors.Control;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(634, 388);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(67, 22);
			this.label9.TabIndex = 44;
			this.label9.Text = "Subtotal";
			// 
			// lblShipping
			// 
			this.lblShipping.BackColor = System.Drawing.Color.White;
			this.lblShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblShipping.ForeColor = System.Drawing.Color.Black;
			this.lblShipping.Location = new System.Drawing.Point(742, 349);
			this.lblShipping.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblShipping.Name = "lblShipping";
			this.lblShipping.Size = new System.Drawing.Size(103, 21);
			this.lblShipping.TabIndex = 42;
			this.lblShipping.Text = "-";
			this.lblShipping.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(612, 349);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(99, 17);
			this.label7.TabIndex = 41;
			this.label7.Text = "Shipping:";
			// 
			// lblPaymentMethod
			// 
			this.lblPaymentMethod.BackColor = System.Drawing.Color.White;
			this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPaymentMethod.ForeColor = System.Drawing.Color.Black;
			this.lblPaymentMethod.Location = new System.Drawing.Point(739, 327);
			this.lblPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPaymentMethod.Name = "lblPaymentMethod";
			this.lblPaymentMethod.Size = new System.Drawing.Size(106, 22);
			this.lblPaymentMethod.TabIndex = 40;
			this.lblPaymentMethod.Text = "-";
			this.lblPaymentMethod.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(612, 330);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(122, 19);
			this.label5.TabIndex = 39;
			this.label5.Text = "Payment method :";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(612, 239);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 14);
			this.label4.TabIndex = 38;
			this.label4.Text = "ID:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(597, 217);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 22);
			this.label3.TabIndex = 37;
			this.label3.Text = "Customer Information:";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Silver;
			this.label1.Location = new System.Drawing.Point(689, 16);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 18);
			this.label1.TabIndex = 35;
			this.label1.Text = "Order #";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(230, 11);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(347, 32);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 56;
			this.pictureBox3.TabStop = false;
			// 
			// btnOrderCheckout
			// 
			this.btnOrderCheckout.BackColor = System.Drawing.Color.Brown;
			this.btnOrderCheckout.BackgroundColor = System.Drawing.Color.Brown;
			this.btnOrderCheckout.BorderColor = System.Drawing.Color.Tomato;
			this.btnOrderCheckout.BorderRadius = 15;
			this.btnOrderCheckout.BorderSize = 0;
			this.btnOrderCheckout.FlatAppearance.BorderSize = 0;
			this.btnOrderCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrderCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.btnOrderCheckout.ForeColor = System.Drawing.Color.White;
			this.btnOrderCheckout.Location = new System.Drawing.Point(587, 473);
			this.btnOrderCheckout.Margin = new System.Windows.Forms.Padding(4);
			this.btnOrderCheckout.Name = "btnOrderCheckout";
			this.btnOrderCheckout.Size = new System.Drawing.Size(284, 48);
			this.btnOrderCheckout.TabIndex = 57;
			this.btnOrderCheckout.Text = "Checkout";
			this.btnOrderCheckout.TextColor = System.Drawing.Color.White;
			this.btnOrderCheckout.UseVisualStyleBackColor = false;
			this.btnOrderCheckout.Click += new System.EventHandler(this.BtnOrderCheckoutClick);
			// 
			// btnApplyDiscount
			// 
			this.btnApplyDiscount.BackColor = System.Drawing.Color.Brown;
			this.btnApplyDiscount.BackgroundColor = System.Drawing.Color.Brown;
			this.btnApplyDiscount.BorderColor = System.Drawing.Color.Tomato;
			this.btnApplyDiscount.BorderRadius = 10;
			this.btnApplyDiscount.BorderSize = 0;
			this.btnApplyDiscount.FlatAppearance.BorderSize = 0;
			this.btnApplyDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnApplyDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnApplyDiscount.ForeColor = System.Drawing.Color.White;
			this.btnApplyDiscount.Location = new System.Drawing.Point(484, 481);
			this.btnApplyDiscount.Margin = new System.Windows.Forms.Padding(4);
			this.btnApplyDiscount.Name = "btnApplyDiscount";
			this.btnApplyDiscount.Size = new System.Drawing.Size(81, 33);
			this.btnApplyDiscount.TabIndex = 66;
			this.btnApplyDiscount.Text = "Apply";
			this.btnApplyDiscount.TextColor = System.Drawing.Color.White;
			this.btnApplyDiscount.UseVisualStyleBackColor = false;
			this.btnApplyDiscount.Click += new System.EventHandler(this.BtnApplyDiscountClick);
			// 
			// lblOrderId
			// 
			this.lblOrderId.BackColor = System.Drawing.Color.White;
			this.lblOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lblOrderId.Location = new System.Drawing.Point(739, 16);
			this.lblOrderId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOrderId.Name = "lblOrderId";
			this.lblOrderId.Size = new System.Drawing.Size(34, 16);
			this.lblOrderId.TabIndex = 0;
			this.lblOrderId.Text = "0";
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.White;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(26, 381);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(110, 17);
			this.label19.TabIndex = 78;
			this.label19.Text = "Customer name:";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.White;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(612, 258);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(67, 17);
			this.label12.TabIndex = 80;
			this.label12.Text = "Name:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.White;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(612, 275);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(67, 24);
			this.label13.TabIndex = 81;
			this.label13.Text = "Phone:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.White;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.ForeColor = System.Drawing.Color.Black;
			this.label21.Location = new System.Drawing.Point(612, 300);
			this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(67, 19);
			this.label21.TabIndex = 82;
			this.label21.Text = "City:";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCustomerId
			// 
			this.lblCustomerId.BackColor = System.Drawing.Color.White;
			this.lblCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomerId.ForeColor = System.Drawing.Color.Black;
			this.lblCustomerId.Location = new System.Drawing.Point(750, 239);
			this.lblCustomerId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCustomerId.Name = "lblCustomerId";
			this.lblCustomerId.Size = new System.Drawing.Size(95, 14);
			this.lblCustomerId.TabIndex = 83;
			this.lblCustomerId.Text = "-";
			this.lblCustomerId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCustomerName
			// 
			this.lblCustomerName.BackColor = System.Drawing.Color.White;
			this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomerName.ForeColor = System.Drawing.Color.Black;
			this.lblCustomerName.Location = new System.Drawing.Point(750, 255);
			this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCustomerName.Name = "lblCustomerName";
			this.lblCustomerName.Size = new System.Drawing.Size(95, 23);
			this.lblCustomerName.TabIndex = 84;
			this.lblCustomerName.Text = "-";
			this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCustomerPhone
			// 
			this.lblCustomerPhone.BackColor = System.Drawing.Color.White;
			this.lblCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomerPhone.ForeColor = System.Drawing.Color.Black;
			this.lblCustomerPhone.Location = new System.Drawing.Point(754, 278);
			this.lblCustomerPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCustomerPhone.Name = "lblCustomerPhone";
			this.lblCustomerPhone.Size = new System.Drawing.Size(91, 16);
			this.lblCustomerPhone.TabIndex = 85;
			this.lblCustomerPhone.Text = "-";
			this.lblCustomerPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCustomerCity
			// 
			this.lblCustomerCity.BackColor = System.Drawing.Color.White;
			this.lblCustomerCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomerCity.ForeColor = System.Drawing.Color.Black;
			this.lblCustomerCity.Location = new System.Drawing.Point(750, 300);
			this.lblCustomerCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCustomerCity.Name = "lblCustomerCity";
			this.lblCustomerCity.Size = new System.Drawing.Size(95, 19);
			this.lblCustomerCity.TabIndex = 86;
			this.lblCustomerCity.Text = "-";
			this.lblCustomerCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(819, 431);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(21, 23);
			this.label18.TabIndex = 87;
			this.label18.Text = ".-";
			// 
			// label22
			// 
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label22.Location = new System.Drawing.Point(12, 14);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(163, 23);
			this.label22.TabIndex = 88;
			this.label22.Text = "Point of Sales";
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(11, 330);
			this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(566, 191);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 89;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(26, 336);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(356, 34);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 2;
			this.pictureBox5.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.flpProductList);
			this.panel1.Location = new System.Drawing.Point(11, 51);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(566, 268);
			this.panel1.TabIndex = 0;
			// 
			// flpProductList
			// 
			this.flpProductList.AutoScroll = true;
			this.flpProductList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpProductList.Location = new System.Drawing.Point(0, 0);
			this.flpProductList.Margin = new System.Windows.Forms.Padding(4);
			this.flpProductList.Name = "flpProductList";
			this.flpProductList.Size = new System.Drawing.Size(566, 268);
			this.flpProductList.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(529, 0);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// cmbDiscount
			// 
			this.cmbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbDiscount.FormattingEnabled = true;
			this.cmbDiscount.Location = new System.Drawing.Point(136, 486);
			this.cmbDiscount.Margin = new System.Windows.Forms.Padding(4);
			this.cmbDiscount.Name = "cmbDiscount";
			this.cmbDiscount.Size = new System.Drawing.Size(246, 23);
			this.cmbDiscount.TabIndex = 90;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Brown;
			this.btnDelete.BackgroundColor = System.Drawing.Color.Brown;
			this.btnDelete.BorderColor = System.Drawing.Color.Tomato;
			this.btnDelete.BorderRadius = 10;
			this.btnDelete.BorderSize = 0;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(813, 201);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(48, 24);
			this.btnDelete.TabIndex = 91;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextColor = System.Drawing.Color.White;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// cmbCustName
			// 
			this.cmbCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbCustName.FormattingEnabled = true;
			this.cmbCustName.Items.AddRange(new object[] {
									"Cash",
									"Credit Card",
									"Bank Transfer"});
			this.cmbCustName.Location = new System.Drawing.Point(30, 402);
			this.cmbCustName.Margin = new System.Windows.Forms.Padding(4);
			this.cmbCustName.Name = "cmbCustName";
			this.cmbCustName.Size = new System.Drawing.Size(158, 21);
			this.cmbCustName.TabIndex = 92;
			this.cmbCustName.TextChanged += new System.EventHandler(this.CmbCustomerNameTextChanged);
			// 
			// FrmPOS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScrollMargin = new System.Drawing.Size(1, 0);
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(884, 531);
			this.Controls.Add(this.cmbCustName);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.cmbDiscount);
			this.Controls.Add(this.lblFreeItem);
			this.Controls.Add(this.cmbPaymentType);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.dtpShippingDate);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.cmbShipping);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblSubtotal);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.lblGrandTotal);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.lblDiscount);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.listViewOrder);
			this.Controls.Add(this.lblCustomerCity);
			this.Controls.Add(this.lblCustomerPhone);
			this.Controls.Add(this.lblCustomerName);
			this.Controls.Add(this.lblCustomerId);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.lblOrderId);
			this.Controls.Add(this.btnApplyDiscount);
			this.Controls.Add(this.btnOrderCheckout);
			this.Controls.Add(this.btnCustSearch);
			this.Controls.Add(this.txtProductSearch);
			this.Controls.Add(this.lblShipping);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblPaymentMethod);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox4);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmPOS";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmPOS";
			this.Load += new System.EventHandler(this.FrmPOSLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox cmbCustName;
		private termProject.RoundedButton btnDelete;
		private System.Windows.Forms.ComboBox cmbDiscount;
		private System.Windows.Forms.Label lblShipping;
		private System.Windows.Forms.Label lblPaymentMethod;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flpProductList;
		private System.Windows.Forms.ColumnHeader columnTotal;
		private System.Windows.Forms.Label lblFreeItem;
		private System.Windows.Forms.Label lblCustomerCity;
		private System.Windows.Forms.Label lblCustomerPhone;
		private System.Windows.Forms.Label lblCustomerName;
		private System.Windows.Forms.Label lblCustomerId;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.ComboBox cmbPaymentType;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtProductSearch;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox cmbShipping;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.DateTimePicker dtpShippingDate;
		private System.Windows.Forms.Label label2;
		private termProject.SemiRoundedButton btnOrderCheckout;
		private termProject.RoundedButton btnApplyDiscount;
		private System.Windows.Forms.Label lblOrderId;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label lblDiscount;
		private System.Windows.Forms.Label lblSubtotal;
		private System.Windows.Forms.Label lblGrandTotal;
		private System.Windows.Forms.ListView listViewOrder;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ColumnHeader columnPrice;
		private System.Windows.Forms.ColumnHeader columnQty;
		private System.Windows.Forms.ColumnHeader columnItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnCustSearch;
		private System.Windows.Forms.Panel panel1;
		
		
		
		
		
		
		
	}
}
