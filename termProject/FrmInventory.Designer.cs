/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 22-Feb-22
 * Time: 5:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace termProject
{
	partial class FrmInventory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventory));
			this.listViewProduct = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.picProduct = new System.Windows.Forms.PictureBox();
			this.lblProductName = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblProductQty = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtStockAdd = new System.Windows.Forms.TextBox();
			this.btnStockAdd = new termProject.RoundedButton();
			this.btnStockReduce = new termProject.RoundedButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnCustSearch = new System.Windows.Forms.Button();
			this.txtProductSearch = new System.Windows.Forms.TextBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.SuspendLayout();
			// 
			// listViewProduct
			// 
			this.listViewProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listViewProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6});
			this.listViewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listViewProduct.FullRowSelect = true;
			this.listViewProduct.Location = new System.Drawing.Point(56, 262);
			this.listViewProduct.Margin = new System.Windows.Forms.Padding(2);
			this.listViewProduct.MultiSelect = false;
			this.listViewProduct.Name = "listViewProduct";
			this.listViewProduct.ShowItemToolTips = true;
			this.listViewProduct.Size = new System.Drawing.Size(801, 231);
			this.listViewProduct.TabIndex = 16;
			this.listViewProduct.UseCompatibleStateImageBehavior = false;
			this.listViewProduct.View = System.Windows.Forms.View.Details;
			this.listViewProduct.SelectedIndexChanged += new System.EventHandler(this.ListViewProductSelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ID";
			this.columnHeader1.Width = 79;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Product";
			this.columnHeader2.Width = 221;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Type";
			this.columnHeader3.Width = 124;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Quantity";
			this.columnHeader4.Width = 69;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Price";
			this.columnHeader5.Width = 67;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Description";
			this.columnHeader6.Width = 240;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 32);
			this.label1.TabIndex = 17;
			this.label1.Text = "Inventory";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label2.Location = new System.Drawing.Point(56, 64);
			this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(151, 22);
			this.label2.TabIndex = 18;
			this.label2.Text = "Product name:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picProduct
			// 
			this.picProduct.BackColor = System.Drawing.Color.White;
			this.picProduct.Location = new System.Drawing.Point(651, 34);
			this.picProduct.Name = "picProduct";
			this.picProduct.Size = new System.Drawing.Size(180, 180);
			this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picProduct.TabIndex = 19;
			this.picProduct.TabStop = false;
			// 
			// lblProductName
			// 
			this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lblProductName.Location = new System.Drawing.Point(209, 64);
			this.lblProductName.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(151, 22);
			this.lblProductName.TabIndex = 20;
			this.lblProductName.Text = "-";
			this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label4.Location = new System.Drawing.Point(56, 95);
			this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(151, 22);
			this.label4.TabIndex = 21;
			this.label4.Text = "Quantity:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblProductQty
			// 
			this.lblProductQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lblProductQty.Location = new System.Drawing.Point(209, 95);
			this.lblProductQty.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.lblProductQty.Name = "lblProductQty";
			this.lblProductQty.Size = new System.Drawing.Size(151, 22);
			this.lblProductQty.TabIndex = 22;
			this.lblProductQty.Text = "0";
			this.lblProductQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblProductQty.TextChanged += new System.EventHandler(this.LblProductQtyTextChanged);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label6.Location = new System.Drawing.Point(56, 152);
			this.label6.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(113, 22);
			this.label6.TabIndex = 23;
			this.label6.Text = "Add stock:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtStockAdd
			// 
			this.txtStockAdd.BackColor = System.Drawing.SystemColors.Control;
			this.txtStockAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtStockAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtStockAdd.Location = new System.Drawing.Point(186, 155);
			this.txtStockAdd.Name = "txtStockAdd";
			this.txtStockAdd.Size = new System.Drawing.Size(56, 15);
			this.txtStockAdd.TabIndex = 24;
			this.txtStockAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnStockAdd
			// 
			this.btnStockAdd.BackColor = System.Drawing.Color.Maroon;
			this.btnStockAdd.BackgroundColor = System.Drawing.Color.Maroon;
			this.btnStockAdd.BorderColor = System.Drawing.Color.Tomato;
			this.btnStockAdd.BorderRadius = 15;
			this.btnStockAdd.BorderSize = 0;
			this.btnStockAdd.FlatAppearance.BorderSize = 0;
			this.btnStockAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStockAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStockAdd.ForeColor = System.Drawing.Color.White;
			this.btnStockAdd.Location = new System.Drawing.Point(419, 152);
			this.btnStockAdd.Name = "btnStockAdd";
			this.btnStockAdd.Size = new System.Drawing.Size(73, 30);
			this.btnStockAdd.TabIndex = 25;
			this.btnStockAdd.Text = "Add";
			this.btnStockAdd.TextColor = System.Drawing.Color.White;
			this.btnStockAdd.UseVisualStyleBackColor = false;
			this.btnStockAdd.Click += new System.EventHandler(this.BtnStockAddClick);
			// 
			// btnStockReduce
			// 
			this.btnStockReduce.BackColor = System.Drawing.Color.Maroon;
			this.btnStockReduce.BackgroundColor = System.Drawing.Color.Maroon;
			this.btnStockReduce.BorderColor = System.Drawing.Color.Tomato;
			this.btnStockReduce.BorderRadius = 15;
			this.btnStockReduce.BorderSize = 0;
			this.btnStockReduce.FlatAppearance.BorderSize = 0;
			this.btnStockReduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStockReduce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStockReduce.ForeColor = System.Drawing.Color.White;
			this.btnStockReduce.Location = new System.Drawing.Point(511, 152);
			this.btnStockReduce.Name = "btnStockReduce";
			this.btnStockReduce.Size = new System.Drawing.Size(73, 30);
			this.btnStockReduce.TabIndex = 25;
			this.btnStockReduce.Text = "Reduce";
			this.btnStockReduce.TextColor = System.Drawing.Color.White;
			this.btnStockReduce.UseVisualStyleBackColor = false;
			this.btnStockReduce.Click += new System.EventHandler(this.BtnStockReduceClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(604, 19);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(268, 213);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 34;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(13, 246);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(858, 273);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 35;
			this.pictureBox2.TabStop = false;
			// 
			// btnCustSearch
			// 
			this.btnCustSearch.BackColor = System.Drawing.Color.White;
			this.btnCustSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCustSearch.FlatAppearance.BorderSize = 0;
			this.btnCustSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustSearch.Location = new System.Drawing.Point(26, 205);
			this.btnCustSearch.Margin = new System.Windows.Forms.Padding(4);
			this.btnCustSearch.Name = "btnCustSearch";
			this.btnCustSearch.Size = new System.Drawing.Size(23, 20);
			this.btnCustSearch.TabIndex = 58;
			this.btnCustSearch.UseVisualStyleBackColor = false;
			// 
			// txtProductSearch
			// 
			this.txtProductSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtProductSearch.Location = new System.Drawing.Point(56, 205);
			this.txtProductSearch.Name = "txtProductSearch";
			this.txtProductSearch.Size = new System.Drawing.Size(514, 19);
			this.txtProductSearch.TabIndex = 57;
			this.txtProductSearch.TextChanged += new System.EventHandler(this.TxtProductSearchTextChanged);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(17, 47);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(10, 143);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 60;
			this.pictureBox4.TabStop = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(182, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 30);
			this.label3.TabIndex = 61;
			this.label3.Text = "________";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(23, 204);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(23, 20);
			this.button1.TabIndex = 63;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(13, 198);
			this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(571, 32);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 62;
			this.pictureBox5.TabStop = false;
			// 
			// FrmInventory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 531);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.btnCustSearch);
			this.Controls.Add(this.txtProductSearch);
			this.Controls.Add(this.btnStockReduce);
			this.Controls.Add(this.btnStockAdd);
			this.Controls.Add(this.txtStockAdd);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblProductQty);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblProductName);
			this.Controls.Add(this.picProduct);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listViewProduct);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox5);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FrmInventory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.FrmInventoryLoad);
			((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.TextBox txtProductSearch;
		private System.Windows.Forms.Button btnCustSearch;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private termProject.RoundedButton btnStockReduce;
		private System.Windows.Forms.TextBox txtStockAdd;
		private termProject.RoundedButton btnStockAdd;
		private System.Windows.Forms.Label lblProductQty;
		private System.Windows.Forms.Label lblProductName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox picProduct;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listViewProduct;
		
		
	}
}
