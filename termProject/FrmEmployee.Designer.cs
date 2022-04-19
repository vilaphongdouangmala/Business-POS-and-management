/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 26-Mar-22
 * Time: 12:19 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace termProject
{
	partial class FrmEmployee
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployee));
			this.btnCustSearch = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.cmbGender = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnUpdate = new termProject.RoundedButton();
			this.btnDelete = new termProject.RoundedButton();
			this.btnAdd = new termProject.RoundedButton();
			this.cmbRole = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dtpDOB = new System.Windows.Forms.DateTimePicker();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.listViewEmployee = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCustSearch
			// 
			this.btnCustSearch.BackColor = System.Drawing.Color.White;
			this.btnCustSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustSearch.BackgroundImage")));
			this.btnCustSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCustSearch.FlatAppearance.BorderSize = 0;
			this.btnCustSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustSearch.Location = new System.Drawing.Point(519, 65);
			this.btnCustSearch.Margin = new System.Windows.Forms.Padding(4);
			this.btnCustSearch.Name = "btnCustSearch";
			this.btnCustSearch.Size = new System.Drawing.Size(23, 20);
			this.btnCustSearch.TabIndex = 90;
			this.btnCustSearch.UseVisualStyleBackColor = false;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.White;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(43, 347);
			this.label12.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(171, 22);
			this.label12.TabIndex = 87;
			this.label12.Text = "Employee Information";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtSearch
			// 
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtSearch.Location = new System.Drawing.Point(43, 65);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(455, 19);
			this.txtSearch.TabIndex = 85;
			this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearchTextChanged);
			// 
			// cmbGender
			// 
			this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbGender.FormattingEnabled = true;
			this.cmbGender.Items.AddRange(new object[] {
									"Male",
									"Female"});
			this.cmbGender.Location = new System.Drawing.Point(155, 454);
			this.cmbGender.Name = "cmbGender";
			this.cmbGender.Size = new System.Drawing.Size(138, 24);
			this.cmbGender.TabIndex = 80;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(57, 457);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(73, 18);
			this.label8.TabIndex = 79;
			this.label8.Text = "Gender:";
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
			this.btnUpdate.Location = new System.Drawing.Point(759, 479);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(73, 30);
			this.btnUpdate.TabIndex = 78;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.TextColor = System.Drawing.Color.White;
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Maroon;
			this.btnDelete.BackgroundColor = System.Drawing.Color.Maroon;
			this.btnDelete.BorderColor = System.Drawing.Color.Tomato;
			this.btnDelete.BorderRadius = 15;
			this.btnDelete.BorderSize = 0;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(663, 479);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(73, 30);
			this.btnDelete.TabIndex = 77;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextColor = System.Drawing.Color.White;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.Maroon;
			this.btnAdd.BackgroundColor = System.Drawing.Color.Maroon;
			this.btnAdd.BorderColor = System.Drawing.Color.Tomato;
			this.btnAdd.BorderRadius = 15;
			this.btnAdd.BorderSize = 0;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(561, 479);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(73, 30);
			this.btnAdd.TabIndex = 76;
			this.btnAdd.Text = "Add";
			this.btnAdd.TextColor = System.Drawing.Color.White;
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// cmbRole
			// 
			this.cmbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbRole.FormattingEnabled = true;
			this.cmbRole.Location = new System.Drawing.Point(155, 372);
			this.cmbRole.Name = "cmbRole";
			this.cmbRole.Size = new System.Drawing.Size(138, 24);
			this.cmbRole.TabIndex = 75;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(56, 375);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 18);
			this.label7.TabIndex = 74;
			this.label7.Text = "Role:";
			// 
			// dtpDOB
			// 
			this.dtpDOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDOB.Location = new System.Drawing.Point(155, 481);
			this.dtpDOB.Name = "dtpDOB";
			this.dtpDOB.Size = new System.Drawing.Size(138, 22);
			this.dtpDOB.TabIndex = 73;
			// 
			// txtFirstName
			// 
			this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFirstName.Location = new System.Drawing.Point(155, 401);
			this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(138, 22);
			this.txtFirstName.TabIndex = 72;
			// 
			// txtPhone
			// 
			this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhone.Location = new System.Drawing.Point(394, 371);
			this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(175, 22);
			this.txtPhone.TabIndex = 71;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(317, 403);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 18);
			this.label5.TabIndex = 68;
			this.label5.Text = "Email:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(29, 12);
			this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 43);
			this.label1.TabIndex = 62;
			this.label1.Text = "Employee";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(29, 339);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(826, 180);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 86;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(29, 98);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(826, 224);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 88;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(29, 60);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(522, 32);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 89;
			this.pictureBox3.TabStop = false;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(57, 484);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 18);
			this.label6.TabIndex = 70;
			this.label6.Text = "Date of Birth:";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(394, 401);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(175, 22);
			this.txtEmail.TabIndex = 69;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(317, 374);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 18);
			this.label4.TabIndex = 67;
			this.label4.Text = "Phone:";
			// 
			// txtLastName
			// 
			this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLastName.Location = new System.Drawing.Point(155, 427);
			this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(138, 22);
			this.txtLastName.TabIndex = 66;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(57, 403);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 18);
			this.label2.TabIndex = 64;
			this.label2.Text = "First name:";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(57, 429);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 18);
			this.label3.TabIndex = 65;
			this.label3.Text = "Last name:";
			// 
			// listViewEmployee
			// 
			this.listViewEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listViewEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6,
									this.columnHeader7,
									this.columnHeader8});
			this.listViewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.listViewEmployee.FullRowSelect = true;
			this.listViewEmployee.Location = new System.Drawing.Point(43, 107);
			this.listViewEmployee.MultiSelect = false;
			this.listViewEmployee.Name = "listViewEmployee";
			this.listViewEmployee.Size = new System.Drawing.Size(799, 207);
			this.listViewEmployee.TabIndex = 91;
			this.listViewEmployee.UseCompatibleStateImageBehavior = false;
			this.listViewEmployee.View = System.Windows.Forms.View.Details;
			this.listViewEmployee.SelectedIndexChanged += new System.EventHandler(this.ListViewEmployeeSelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ID";
			this.columnHeader1.Width = 61;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "First name";
			this.columnHeader2.Width = 116;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Last name";
			this.columnHeader3.Width = 120;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Date of Birth";
			this.columnHeader4.Width = 103;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Gender";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Email";
			this.columnHeader6.Width = 113;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Phone";
			this.columnHeader7.Width = 113;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Role";
			this.columnHeader8.Width = 83;
			// 
			// FrmEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 531);
			this.Controls.Add(this.listViewEmployee);
			this.Controls.Add(this.btnCustSearch);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.cmbGender);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.cmbRole);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dtpDOB);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FrmEmployee";
			this.Text = "FrmEmployee";
			this.Load += new System.EventHandler(this.FrmEmployeeLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ListView listViewEmployee;
		private termProject.RoundedButton btnUpdate;
		private termProject.RoundedButton btnDelete;
		private termProject.RoundedButton btnAdd;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.DateTimePicker dtpDOB;
		private System.Windows.Forms.ComboBox cmbGender;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.ComboBox cmbRole;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnCustSearch;
	}
}
