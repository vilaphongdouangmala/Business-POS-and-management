/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 08-Feb-22
 * Time: 10:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace termProject
{
	partial class FrmCustomer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
			this.label1 = new System.Windows.Forms.Label();
			this.listViewCust = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCustLastName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCustEmail = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCustPhone = new System.Windows.Forms.TextBox();
			this.txtCustFirstName = new System.Windows.Forms.TextBox();
			this.dtpCustDOB = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbCustType = new System.Windows.Forms.ComboBox();
			this.btnCustAdd = new termProject.RoundedButton();
			this.btnCustDelete = new termProject.RoundedButton();
			this.btnCustUpdate = new termProject.RoundedButton();
			this.cmbCustGender = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbCustCity = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtCustAddress = new System.Windows.Forms.TextBox();
			this.txtCustSearch = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label12 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.btnCustSearch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(29, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 43);
			this.label1.TabIndex = 0;
			this.label1.Text = "Customer";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// listViewCust
			// 
			this.listViewCust.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listViewCust.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6,
									this.columnHeader7,
									this.columnHeader8,
									this.columnHeader9,
									this.columnHeader10});
			this.listViewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listViewCust.FullRowSelect = true;
			this.listViewCust.Location = new System.Drawing.Point(43, 104);
			this.listViewCust.Margin = new System.Windows.Forms.Padding(2);
			this.listViewCust.MultiSelect = false;
			this.listViewCust.Name = "listViewCust";
			this.listViewCust.ShowItemToolTips = true;
			this.listViewCust.Size = new System.Drawing.Size(797, 206);
			this.listViewCust.TabIndex = 1;
			this.listViewCust.UseCompatibleStateImageBehavior = false;
			this.listViewCust.View = System.Windows.Forms.View.Details;
			this.listViewCust.SelectedIndexChanged += new System.EventHandler(this.ListViewCustSelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ID";
			this.columnHeader1.Width = 40;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "First name";
			this.columnHeader2.Width = 93;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Last name";
			this.columnHeader3.Width = 93;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Gender";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Date of Birth";
			this.columnHeader5.Width = 97;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Type";
			this.columnHeader6.Width = 84;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Phone";
			this.columnHeader7.Width = 128;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Address";
			this.columnHeader8.Width = 151;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "City";
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Email";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(57, 398);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "First name:";
			// 
			// txtCustLastName
			// 
			this.txtCustLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCustLastName.Location = new System.Drawing.Point(155, 424);
			this.txtCustLastName.Margin = new System.Windows.Forms.Padding(2);
			this.txtCustLastName.Name = "txtCustLastName";
			this.txtCustLastName.Size = new System.Drawing.Size(138, 22);
			this.txtCustLastName.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(57, 424);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "Last name:";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(317, 368);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 18);
			this.label4.TabIndex = 6;
			this.label4.Text = "Phone:";
			// 
			// txtCustEmail
			// 
			this.txtCustEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCustEmail.Location = new System.Drawing.Point(394, 398);
			this.txtCustEmail.Margin = new System.Windows.Forms.Padding(2);
			this.txtCustEmail.Name = "txtCustEmail";
			this.txtCustEmail.Size = new System.Drawing.Size(175, 22);
			this.txtCustEmail.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(317, 397);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 18);
			this.label5.TabIndex = 8;
			this.label5.Text = "Email:";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(57, 481);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 18);
			this.label6.TabIndex = 10;
			this.label6.Text = "Date of Birth:";
			// 
			// txtCustPhone
			// 
			this.txtCustPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCustPhone.Location = new System.Drawing.Point(394, 368);
			this.txtCustPhone.Margin = new System.Windows.Forms.Padding(2);
			this.txtCustPhone.Name = "txtCustPhone";
			this.txtCustPhone.Size = new System.Drawing.Size(175, 22);
			this.txtCustPhone.TabIndex = 12;
			// 
			// txtCustFirstName
			// 
			this.txtCustFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCustFirstName.Location = new System.Drawing.Point(155, 398);
			this.txtCustFirstName.Margin = new System.Windows.Forms.Padding(2);
			this.txtCustFirstName.Name = "txtCustFirstName";
			this.txtCustFirstName.Size = new System.Drawing.Size(138, 22);
			this.txtCustFirstName.TabIndex = 13;
			// 
			// dtpCustDOB
			// 
			this.dtpCustDOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			this.dtpCustDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpCustDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpCustDOB.Location = new System.Drawing.Point(155, 478);
			this.dtpCustDOB.Name = "dtpCustDOB";
			this.dtpCustDOB.Size = new System.Drawing.Size(138, 22);
			this.dtpCustDOB.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(56, 372);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 18);
			this.label7.TabIndex = 15;
			this.label7.Text = "Type:";
			// 
			// cmbCustType
			// 
			this.cmbCustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbCustType.FormattingEnabled = true;
			this.cmbCustType.Location = new System.Drawing.Point(155, 369);
			this.cmbCustType.Name = "cmbCustType";
			this.cmbCustType.Size = new System.Drawing.Size(138, 24);
			this.cmbCustType.TabIndex = 16;
			// 
			// btnCustAdd
			// 
			this.btnCustAdd.BackColor = System.Drawing.Color.Maroon;
			this.btnCustAdd.BackgroundColor = System.Drawing.Color.Maroon;
			this.btnCustAdd.BorderColor = System.Drawing.Color.Tomato;
			this.btnCustAdd.BorderRadius = 15;
			this.btnCustAdd.BorderSize = 0;
			this.btnCustAdd.FlatAppearance.BorderSize = 0;
			this.btnCustAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCustAdd.ForeColor = System.Drawing.Color.White;
			this.btnCustAdd.Location = new System.Drawing.Point(561, 476);
			this.btnCustAdd.Name = "btnCustAdd";
			this.btnCustAdd.Size = new System.Drawing.Size(73, 30);
			this.btnCustAdd.TabIndex = 17;
			this.btnCustAdd.Text = "Add";
			this.btnCustAdd.TextColor = System.Drawing.Color.White;
			this.btnCustAdd.UseVisualStyleBackColor = false;
			this.btnCustAdd.Click += new System.EventHandler(this.BtnCustAddClick);
			// 
			// btnCustDelete
			// 
			this.btnCustDelete.BackColor = System.Drawing.Color.Maroon;
			this.btnCustDelete.BackgroundColor = System.Drawing.Color.Maroon;
			this.btnCustDelete.BorderColor = System.Drawing.Color.Tomato;
			this.btnCustDelete.BorderRadius = 15;
			this.btnCustDelete.BorderSize = 0;
			this.btnCustDelete.FlatAppearance.BorderSize = 0;
			this.btnCustDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCustDelete.ForeColor = System.Drawing.Color.White;
			this.btnCustDelete.Location = new System.Drawing.Point(663, 476);
			this.btnCustDelete.Name = "btnCustDelete";
			this.btnCustDelete.Size = new System.Drawing.Size(73, 30);
			this.btnCustDelete.TabIndex = 18;
			this.btnCustDelete.Text = "Delete";
			this.btnCustDelete.TextColor = System.Drawing.Color.White;
			this.btnCustDelete.UseVisualStyleBackColor = false;
			this.btnCustDelete.Click += new System.EventHandler(this.BtnCustDeleteClick);
			// 
			// btnCustUpdate
			// 
			this.btnCustUpdate.BackColor = System.Drawing.Color.Maroon;
			this.btnCustUpdate.BackgroundColor = System.Drawing.Color.Maroon;
			this.btnCustUpdate.BorderColor = System.Drawing.Color.Tomato;
			this.btnCustUpdate.BorderRadius = 15;
			this.btnCustUpdate.BorderSize = 0;
			this.btnCustUpdate.FlatAppearance.BorderSize = 0;
			this.btnCustUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCustUpdate.ForeColor = System.Drawing.Color.White;
			this.btnCustUpdate.Location = new System.Drawing.Point(759, 476);
			this.btnCustUpdate.Name = "btnCustUpdate";
			this.btnCustUpdate.Size = new System.Drawing.Size(73, 30);
			this.btnCustUpdate.TabIndex = 19;
			this.btnCustUpdate.Text = "Update";
			this.btnCustUpdate.TextColor = System.Drawing.Color.White;
			this.btnCustUpdate.UseVisualStyleBackColor = false;
			this.btnCustUpdate.Click += new System.EventHandler(this.BtnCustUpdateClick);
			// 
			// cmbCustGender
			// 
			this.cmbCustGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbCustGender.FormattingEnabled = true;
			this.cmbCustGender.Items.AddRange(new object[] {
									"Male",
									"Female"});
			this.cmbCustGender.Location = new System.Drawing.Point(155, 451);
			this.cmbCustGender.Name = "cmbCustGender";
			this.cmbCustGender.Size = new System.Drawing.Size(138, 24);
			this.cmbCustGender.TabIndex = 21;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(57, 454);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(73, 18);
			this.label8.TabIndex = 20;
			this.label8.Text = "Gender:";
			// 
			// cmbCustCity
			// 
			this.cmbCustCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbCustCity.FormattingEnabled = true;
			this.cmbCustCity.Location = new System.Drawing.Point(395, 425);
			this.cmbCustCity.Name = "cmbCustCity";
			this.cmbCustCity.Size = new System.Drawing.Size(174, 24);
			this.cmbCustCity.TabIndex = 23;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(317, 425);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(73, 18);
			this.label9.TabIndex = 22;
			this.label9.Text = "City:";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.White;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(594, 363);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(74, 18);
			this.label10.TabIndex = 24;
			this.label10.Text = "Address:";
			// 
			// txtCustAddress
			// 
			this.txtCustAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCustAddress.Location = new System.Drawing.Point(595, 387);
			this.txtCustAddress.Multiline = true;
			this.txtCustAddress.Name = "txtCustAddress";
			this.txtCustAddress.Size = new System.Drawing.Size(235, 62);
			this.txtCustAddress.TabIndex = 25;
			// 
			// txtCustSearch
			// 
			this.txtCustSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCustSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtCustSearch.Location = new System.Drawing.Point(43, 62);
			this.txtCustSearch.Margin = new System.Windows.Forms.Padding(2);
			this.txtCustSearch.Name = "txtCustSearch";
			this.txtCustSearch.Size = new System.Drawing.Size(455, 19);
			this.txtCustSearch.TabIndex = 26;
			this.txtCustSearch.TextChanged += new System.EventHandler(this.TxtCustSearchTextChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(29, 336);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(826, 180);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 34;
			this.pictureBox1.TabStop = false;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.White;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(48, 341);
			this.label12.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(171, 22);
			this.label12.TabIndex = 35;
			this.label12.Text = "Customer Information";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(29, 95);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(826, 224);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 59;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(29, 57);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(522, 32);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 60;
			this.pictureBox3.TabStop = false;
			// 
			// btnCustSearch
			// 
			this.btnCustSearch.BackColor = System.Drawing.Color.White;
			this.btnCustSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustSearch.BackgroundImage")));
			this.btnCustSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCustSearch.FlatAppearance.BorderSize = 0;
			this.btnCustSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustSearch.Location = new System.Drawing.Point(519, 62);
			this.btnCustSearch.Margin = new System.Windows.Forms.Padding(4);
			this.btnCustSearch.Name = "btnCustSearch";
			this.btnCustSearch.Size = new System.Drawing.Size(23, 20);
			this.btnCustSearch.TabIndex = 61;
			this.btnCustSearch.UseVisualStyleBackColor = false;
			// 
			// FrmCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(884, 531);
			this.Controls.Add(this.btnCustSearch);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtCustSearch);
			this.Controls.Add(this.txtCustAddress);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.cmbCustCity);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.cmbCustGender);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnCustUpdate);
			this.Controls.Add(this.btnCustDelete);
			this.Controls.Add(this.btnCustAdd);
			this.Controls.Add(this.cmbCustType);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dtpCustDOB);
			this.Controls.Add(this.txtCustFirstName);
			this.Controls.Add(this.txtCustPhone);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtCustEmail);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCustLastName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listViewCust);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox3);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Name = "FrmCustomer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmCustomer";
			this.Load += new System.EventHandler(this.FrmCustomerLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Button btnCustSearch;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtCustSearch;
		private System.Windows.Forms.TextBox txtCustAddress;
		private System.Windows.Forms.ListView listViewCust;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cmbCustCity;
		private System.Windows.Forms.ComboBox cmbCustGender;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtCustEmail;
		private System.Windows.Forms.TextBox txtCustLastName;
		private System.Windows.Forms.TextBox txtCustPhone;
		private System.Windows.Forms.TextBox txtCustFirstName;
		private System.Windows.Forms.ComboBox cmbCustType;
		private termProject.RoundedButton btnCustDelete;
		private termProject.RoundedButton btnCustUpdate;
		private termProject.RoundedButton btnCustAdd;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dtpCustDOB;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
	
	}
}
