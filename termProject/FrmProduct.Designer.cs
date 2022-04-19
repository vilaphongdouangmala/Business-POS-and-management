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
	partial class FrmProduct
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.listViewProduct = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbProductType = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtProdDes = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtProductQty = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtProductPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnProductUpdate = new termProject.RoundedButton();
			this.btnProductDelete = new termProject.RoundedButton();
			this.btnProductAdd = new termProject.RoundedButton();
			this.txtProductSearch = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.picProduct = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnCustSearch = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.btnUpload = new termProject.RoundedButton();
			this.lblUploadName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// txtProductName
			// 
			this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductName.Location = new System.Drawing.Point(705, 194);
			this.txtProductName.Margin = new System.Windows.Forms.Padding(2);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(151, 21);
			this.txtProductName.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(606, 196);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 18);
			this.label2.TabIndex = 16;
			this.label2.Text = "Product name:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
			this.listViewProduct.Location = new System.Drawing.Point(35, 132);
			this.listViewProduct.Margin = new System.Windows.Forms.Padding(2);
			this.listViewProduct.MultiSelect = false;
			this.listViewProduct.Name = "listViewProduct";
			this.listViewProduct.ShowItemToolTips = true;
			this.listViewProduct.Size = new System.Drawing.Size(517, 370);
			this.listViewProduct.TabIndex = 15;
			this.listViewProduct.UseCompatibleStateImageBehavior = false;
			this.listViewProduct.View = System.Windows.Forms.View.Details;
			this.listViewProduct.SelectedIndexChanged += new System.EventHandler(this.ListViewProductSelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ID";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Product";
			this.columnHeader2.Width = 97;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Type";
			this.columnHeader3.Width = 76;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Quantity";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Price";
			this.columnHeader5.Width = 72;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Description";
			this.columnHeader6.Width = 148;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 13);
			this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 29);
			this.label1.TabIndex = 14;
			this.label1.Text = "Products";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmbProductType
			// 
			this.cmbProductType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbProductType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.cmbProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbProductType.FormattingEnabled = true;
			this.cmbProductType.Location = new System.Drawing.Point(706, 229);
			this.cmbProductType.Name = "cmbProductType";
			this.cmbProductType.Size = new System.Drawing.Size(150, 23);
			this.cmbProductType.TabIndex = 19;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(607, 229);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 18);
			this.label7.TabIndex = 18;
			this.label7.Text = "Type:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// txtProdDes
			// 
			this.txtProdDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProdDes.Location = new System.Drawing.Point(610, 355);
			this.txtProdDes.Multiline = true;
			this.txtProdDes.Name = "txtProdDes";
			this.txtProdDes.Size = new System.Drawing.Size(246, 53);
			this.txtProdDes.TabIndex = 27;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.White;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(607, 334);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(94, 18);
			this.label10.TabIndex = 26;
			this.label10.Text = "Description:";
			// 
			// txtProductQty
			// 
			this.txtProductQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductQty.Location = new System.Drawing.Point(705, 268);
			this.txtProductQty.Margin = new System.Windows.Forms.Padding(2);
			this.txtProductQty.Name = "txtProductQty";
			this.txtProductQty.Size = new System.Drawing.Size(150, 21);
			this.txtProductQty.TabIndex = 29;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(607, 271);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 18);
			this.label3.TabIndex = 28;
			this.label3.Text = "Qty in stock:";
			// 
			// txtProductPrice
			// 
			this.txtProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductPrice.Location = new System.Drawing.Point(706, 305);
			this.txtProductPrice.Margin = new System.Windows.Forms.Padding(2);
			this.txtProductPrice.Name = "txtProductPrice";
			this.txtProductPrice.Size = new System.Drawing.Size(150, 21);
			this.txtProductPrice.TabIndex = 31;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(607, 305);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 18);
			this.label4.TabIndex = 30;
			this.label4.Text = "Price:";
			// 
			// btnProductUpdate
			// 
			this.btnProductUpdate.BackColor = System.Drawing.Color.Maroon;
			this.btnProductUpdate.BackgroundColor = System.Drawing.Color.Maroon;
			this.btnProductUpdate.BorderColor = System.Drawing.Color.Tomato;
			this.btnProductUpdate.BorderRadius = 14;
			this.btnProductUpdate.BorderSize = 0;
			this.btnProductUpdate.FlatAppearance.BorderSize = 0;
			this.btnProductUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProductUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProductUpdate.ForeColor = System.Drawing.Color.White;
			this.btnProductUpdate.Location = new System.Drawing.Point(786, 467);
			this.btnProductUpdate.Name = "btnProductUpdate";
			this.btnProductUpdate.Size = new System.Drawing.Size(70, 35);
			this.btnProductUpdate.TabIndex = 34;
			this.btnProductUpdate.Text = "Update";
			this.btnProductUpdate.TextColor = System.Drawing.Color.White;
			this.btnProductUpdate.UseVisualStyleBackColor = false;
			this.btnProductUpdate.Click += new System.EventHandler(this.BtnProductUpdateClick);
			// 
			// btnProductDelete
			// 
			this.btnProductDelete.BackColor = System.Drawing.Color.Maroon;
			this.btnProductDelete.BackgroundColor = System.Drawing.Color.Maroon;
			this.btnProductDelete.BorderColor = System.Drawing.Color.Tomato;
			this.btnProductDelete.BorderRadius = 14;
			this.btnProductDelete.BorderSize = 0;
			this.btnProductDelete.FlatAppearance.BorderSize = 0;
			this.btnProductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProductDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProductDelete.ForeColor = System.Drawing.Color.White;
			this.btnProductDelete.Location = new System.Drawing.Point(701, 467);
			this.btnProductDelete.Name = "btnProductDelete";
			this.btnProductDelete.Size = new System.Drawing.Size(70, 35);
			this.btnProductDelete.TabIndex = 34;
			this.btnProductDelete.Text = "Delete";
			this.btnProductDelete.TextColor = System.Drawing.Color.White;
			this.btnProductDelete.UseVisualStyleBackColor = false;
			this.btnProductDelete.Click += new System.EventHandler(this.BtnProductDeleteClick);
			// 
			// btnProductAdd
			// 
			this.btnProductAdd.BackColor = System.Drawing.Color.Maroon;
			this.btnProductAdd.BackgroundColor = System.Drawing.Color.Maroon;
			this.btnProductAdd.BorderColor = System.Drawing.Color.Tomato;
			this.btnProductAdd.BorderRadius = 14;
			this.btnProductAdd.BorderSize = 0;
			this.btnProductAdd.FlatAppearance.BorderSize = 0;
			this.btnProductAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProductAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProductAdd.ForeColor = System.Drawing.Color.White;
			this.btnProductAdd.Location = new System.Drawing.Point(606, 467);
			this.btnProductAdd.Name = "btnProductAdd";
			this.btnProductAdd.Size = new System.Drawing.Size(70, 35);
			this.btnProductAdd.TabIndex = 34;
			this.btnProductAdd.Text = "Add";
			this.btnProductAdd.TextColor = System.Drawing.Color.White;
			this.btnProductAdd.UseVisualStyleBackColor = false;
			this.btnProductAdd.Click += new System.EventHandler(this.BtnProductAddClick);
			// 
			// txtProductSearch
			// 
			this.txtProductSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductSearch.Location = new System.Drawing.Point(52, 80);
			this.txtProductSearch.Margin = new System.Windows.Forms.Padding(2);
			this.txtProductSearch.Name = "txtProductSearch";
			this.txtProductSearch.Size = new System.Drawing.Size(500, 15);
			this.txtProductSearch.TabIndex = 35;
			this.txtProductSearch.TextChanged += new System.EventHandler(this.TxtProductSearchTextChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(587, 13);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(284, 505);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 38;
			this.pictureBox1.TabStop = false;
			// 
			// picProduct
			// 
			this.picProduct.BackColor = System.Drawing.Color.White;
			this.picProduct.Location = new System.Drawing.Point(657, 35);
			this.picProduct.Name = "picProduct";
			this.picProduct.Size = new System.Drawing.Size(147, 137);
			this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picProduct.TabIndex = 39;
			this.picProduct.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(13, 111);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(556, 407);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 40;
			this.pictureBox2.TabStop = false;
			// 
			// btnCustSearch
			// 
			this.btnCustSearch.BackColor = System.Drawing.Color.White;
			this.btnCustSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCustSearch.FlatAppearance.BorderSize = 0;
			this.btnCustSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustSearch.Location = new System.Drawing.Point(23, 76);
			this.btnCustSearch.Margin = new System.Windows.Forms.Padding(4);
			this.btnCustSearch.Name = "btnCustSearch";
			this.btnCustSearch.Size = new System.Drawing.Size(23, 20);
			this.btnCustSearch.TabIndex = 58;
			this.btnCustSearch.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(23, 77);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(23, 20);
			this.button1.TabIndex = 63;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(13, 71);
			this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(556, 32);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 62;
			this.pictureBox4.TabStop = false;
			// 
			// btnUpload
			// 
			this.btnUpload.BackColor = System.Drawing.Color.Maroon;
			this.btnUpload.BackgroundColor = System.Drawing.Color.Maroon;
			this.btnUpload.BorderColor = System.Drawing.Color.Tomato;
			this.btnUpload.BorderRadius = 14;
			this.btnUpload.BorderSize = 0;
			this.btnUpload.FlatAppearance.BorderSize = 0;
			this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			this.btnUpload.ForeColor = System.Drawing.Color.White;
			this.btnUpload.Location = new System.Drawing.Point(803, 424);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(53, 29);
			this.btnUpload.TabIndex = 64;
			this.btnUpload.Text = "Upload";
			this.btnUpload.TextColor = System.Drawing.Color.White;
			this.btnUpload.UseVisualStyleBackColor = false;
			this.btnUpload.Click += new System.EventHandler(this.BtnUploadClick);
			// 
			// lblUploadName
			// 
			this.lblUploadName.BackColor = System.Drawing.Color.White;
			this.lblUploadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUploadName.Location = new System.Drawing.Point(610, 429);
			this.lblUploadName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblUploadName.Name = "lblUploadName";
			this.lblUploadName.Size = new System.Drawing.Size(188, 18);
			this.lblUploadName.TabIndex = 65;
			this.lblUploadName.Text = "<upload>";
			this.lblUploadName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FrmProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 531);
			this.Controls.Add(this.lblUploadName);
			this.Controls.Add(this.btnUpload);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnCustSearch);
			this.Controls.Add(this.picProduct);
			this.Controls.Add(this.txtProductSearch);
			this.Controls.Add(this.btnProductUpdate);
			this.Controls.Add(this.btnProductDelete);
			this.Controls.Add(this.btnProductAdd);
			this.Controls.Add(this.txtProductPrice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtProductQty);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtProdDes);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.cmbProductType);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listViewProduct);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox4);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FrmProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmProduct";
			this.Load += new System.EventHandler(this.FrmProductLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblUploadName;
		private termProject.RoundedButton btnUpload;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnCustSearch;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox picProduct;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtProductSearch;
		private System.Windows.Forms.TextBox txtProductPrice;
		private System.Windows.Forms.TextBox txtProductQty;
		private System.Windows.Forms.ListView listViewProduct;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private termProject.RoundedButton btnProductAdd;
		private termProject.RoundedButton btnProductDelete;
		private termProject.RoundedButton btnProductUpdate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtProdDes;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbProductType;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}
