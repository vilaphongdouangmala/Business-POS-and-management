/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 08-Feb-22
 * Time: 10:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace termProject
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pnlNavBar = new System.Windows.Forms.Panel();
			this.btnFrmReport = new System.Windows.Forms.Button();
			this.btnFrmOrder = new System.Windows.Forms.Button();
			this.btnFrmEmployee = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnFrmCustomer = new System.Windows.Forms.Button();
			this.btnFrmInventory = new System.Windows.Forms.Button();
			this.btnFrmProduct = new System.Windows.Forms.Button();
			this.btnFrmPOS = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.pnlSelectedForm = new System.Windows.Forms.Panel();
			this.pnlNavBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlNavBar
			// 
			this.pnlNavBar.BackColor = System.Drawing.Color.Maroon;
			this.pnlNavBar.Controls.Add(this.btnFrmReport);
			this.pnlNavBar.Controls.Add(this.btnFrmOrder);
			this.pnlNavBar.Controls.Add(this.btnFrmEmployee);
			this.pnlNavBar.Controls.Add(this.pictureBox1);
			this.pnlNavBar.Controls.Add(this.btnFrmCustomer);
			this.pnlNavBar.Controls.Add(this.btnFrmInventory);
			this.pnlNavBar.Controls.Add(this.btnFrmProduct);
			this.pnlNavBar.Controls.Add(this.btnFrmPOS);
			this.pnlNavBar.Controls.Add(this.button1);
			this.pnlNavBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlNavBar.Location = new System.Drawing.Point(0, 0);
			this.pnlNavBar.Name = "pnlNavBar";
			this.pnlNavBar.Size = new System.Drawing.Size(96, 531);
			this.pnlNavBar.TabIndex = 0;
			// 
			// btnFrmReport
			// 
			this.btnFrmReport.BackColor = System.Drawing.Color.Maroon;
			this.btnFrmReport.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnFrmReport.FlatAppearance.BorderSize = 0;
			this.btnFrmReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFrmReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFrmReport.ForeColor = System.Drawing.Color.White;
			this.btnFrmReport.Location = new System.Drawing.Point(0, 406);
			this.btnFrmReport.Name = "btnFrmReport";
			this.btnFrmReport.Size = new System.Drawing.Size(96, 58);
			this.btnFrmReport.TabIndex = 7;
			this.btnFrmReport.Text = "Report";
			this.btnFrmReport.UseVisualStyleBackColor = false;
			this.btnFrmReport.Click += new System.EventHandler(this.BtnFrmReportClick);
			// 
			// btnFrmOrder
			// 
			this.btnFrmOrder.BackColor = System.Drawing.Color.Maroon;
			this.btnFrmOrder.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnFrmOrder.FlatAppearance.BorderSize = 0;
			this.btnFrmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFrmOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFrmOrder.ForeColor = System.Drawing.Color.White;
			this.btnFrmOrder.Location = new System.Drawing.Point(0, 348);
			this.btnFrmOrder.Name = "btnFrmOrder";
			this.btnFrmOrder.Size = new System.Drawing.Size(96, 58);
			this.btnFrmOrder.TabIndex = 6;
			this.btnFrmOrder.Text = "Order";
			this.btnFrmOrder.UseVisualStyleBackColor = false;
			this.btnFrmOrder.Click += new System.EventHandler(this.BtnFrmOrderClick);
			// 
			// btnFrmEmployee
			// 
			this.btnFrmEmployee.BackColor = System.Drawing.Color.Maroon;
			this.btnFrmEmployee.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnFrmEmployee.FlatAppearance.BorderSize = 0;
			this.btnFrmEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFrmEmployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFrmEmployee.ForeColor = System.Drawing.Color.White;
			this.btnFrmEmployee.Location = new System.Drawing.Point(0, 290);
			this.btnFrmEmployee.Name = "btnFrmEmployee";
			this.btnFrmEmployee.Size = new System.Drawing.Size(96, 58);
			this.btnFrmEmployee.TabIndex = 5;
			this.btnFrmEmployee.Text = "Employee";
			this.btnFrmEmployee.UseVisualStyleBackColor = false;
			this.btnFrmEmployee.Click += new System.EventHandler(this.BtnFrmEmployeeClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(29, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(38, 40);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnFrmCustomer
			// 
			this.btnFrmCustomer.BackColor = System.Drawing.Color.Maroon;
			this.btnFrmCustomer.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnFrmCustomer.FlatAppearance.BorderSize = 0;
			this.btnFrmCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFrmCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFrmCustomer.ForeColor = System.Drawing.Color.White;
			this.btnFrmCustomer.Location = new System.Drawing.Point(0, 232);
			this.btnFrmCustomer.Name = "btnFrmCustomer";
			this.btnFrmCustomer.Size = new System.Drawing.Size(96, 58);
			this.btnFrmCustomer.TabIndex = 4;
			this.btnFrmCustomer.Text = "Customer";
			this.btnFrmCustomer.UseVisualStyleBackColor = false;
			this.btnFrmCustomer.Click += new System.EventHandler(this.BtnFrmCustomerClick);
			// 
			// btnFrmInventory
			// 
			this.btnFrmInventory.BackColor = System.Drawing.Color.Maroon;
			this.btnFrmInventory.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnFrmInventory.FlatAppearance.BorderSize = 0;
			this.btnFrmInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFrmInventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFrmInventory.ForeColor = System.Drawing.Color.White;
			this.btnFrmInventory.Location = new System.Drawing.Point(0, 174);
			this.btnFrmInventory.Name = "btnFrmInventory";
			this.btnFrmInventory.Size = new System.Drawing.Size(96, 58);
			this.btnFrmInventory.TabIndex = 3;
			this.btnFrmInventory.Text = "Inventory";
			this.btnFrmInventory.UseVisualStyleBackColor = false;
			this.btnFrmInventory.Click += new System.EventHandler(this.BtnFrmInventoryClick);
			// 
			// btnFrmProduct
			// 
			this.btnFrmProduct.BackColor = System.Drawing.Color.Maroon;
			this.btnFrmProduct.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnFrmProduct.FlatAppearance.BorderSize = 0;
			this.btnFrmProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFrmProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFrmProduct.ForeColor = System.Drawing.Color.White;
			this.btnFrmProduct.Location = new System.Drawing.Point(0, 116);
			this.btnFrmProduct.Name = "btnFrmProduct";
			this.btnFrmProduct.Size = new System.Drawing.Size(96, 58);
			this.btnFrmProduct.TabIndex = 2;
			this.btnFrmProduct.Text = "Product";
			this.btnFrmProduct.UseVisualStyleBackColor = false;
			this.btnFrmProduct.Click += new System.EventHandler(this.BtnFrmProductClick);
			// 
			// btnFrmPOS
			// 
			this.btnFrmPOS.BackColor = System.Drawing.Color.Maroon;
			this.btnFrmPOS.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnFrmPOS.FlatAppearance.BorderSize = 0;
			this.btnFrmPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFrmPOS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFrmPOS.ForeColor = System.Drawing.Color.White;
			this.btnFrmPOS.Location = new System.Drawing.Point(0, 58);
			this.btnFrmPOS.Name = "btnFrmPOS";
			this.btnFrmPOS.Size = new System.Drawing.Size(96, 58);
			this.btnFrmPOS.TabIndex = 1;
			this.btnFrmPOS.Text = "POS";
			this.btnFrmPOS.UseVisualStyleBackColor = false;
			this.btnFrmPOS.Click += new System.EventHandler(this.BtnFrmPOSClick);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Maroon;
			this.button1.Dock = System.Windows.Forms.DockStyle.Top;
			this.button1.Enabled = false;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 58);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// pnlSelectedForm
			// 
			this.pnlSelectedForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlSelectedForm.Location = new System.Drawing.Point(96, 0);
			this.pnlSelectedForm.Name = "pnlSelectedForm";
			this.pnlSelectedForm.Size = new System.Drawing.Size(888, 531);
			this.pnlSelectedForm.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 531);
			this.Controls.Add(this.pnlSelectedForm);
			this.Controls.Add(this.pnlNavBar);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BANDITH ELECTRIC";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.pnlNavBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnFrmOrder;
		private System.Windows.Forms.Button btnFrmReport;
		private System.Windows.Forms.Button btnFrmEmployee;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel pnlSelectedForm;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnFrmPOS;
		private System.Windows.Forms.Button btnFrmProduct;
		private System.Windows.Forms.Button btnFrmInventory;
		private System.Windows.Forms.Button btnFrmCustomer;
		private System.Windows.Forms.Panel pnlNavBar;
	}
}
