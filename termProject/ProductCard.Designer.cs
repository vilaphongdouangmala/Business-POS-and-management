/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 17-Feb-22
 * Time: 7:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace termProject
{
	partial class ProductCard
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCard));
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnAddToList = new termProject.RoundedButton();
			this.btnDecQty = new termProject.RoundedButton();
			this.btnIncQty = new termProject.RoundedButton();
			this.txtProductQty = new System.Windows.Forms.TextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lblProductName = new System.Windows.Forms.Label();
			this.pbProductPic = new System.Windows.Forms.PictureBox();
			this.lblProductPrice = new System.Windows.Forms.Label();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbProductPic)).BeginInit();
			this.SuspendLayout();
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.Controls.Add(this.btnAddToList);
			this.panel4.Controls.Add(this.btnDecQty);
			this.panel4.Controls.Add(this.btnIncQty);
			this.panel4.Controls.Add(this.txtProductQty);
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Location = new System.Drawing.Point(3, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(173, 213);
			this.panel4.TabIndex = 44;
			// 
			// btnAddToList
			// 
			this.btnAddToList.BackColor = System.Drawing.Color.Maroon;
			this.btnAddToList.BackgroundColor = System.Drawing.Color.Maroon;
			this.btnAddToList.BorderColor = System.Drawing.Color.Tomato;
			this.btnAddToList.BorderRadius = 5;
			this.btnAddToList.BorderSize = 0;
			this.btnAddToList.FlatAppearance.BorderSize = 0;
			this.btnAddToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddToList.Font = new System.Drawing.Font("Segoe UI", 9.25F);
			this.btnAddToList.ForeColor = System.Drawing.Color.White;
			this.btnAddToList.Location = new System.Drawing.Point(25, 172);
			this.btnAddToList.Name = "btnAddToList";
			this.btnAddToList.Size = new System.Drawing.Size(128, 28);
			this.btnAddToList.TabIndex = 4;
			this.btnAddToList.Text = "Add to list";
			this.btnAddToList.TextColor = System.Drawing.Color.White;
			this.btnAddToList.UseVisualStyleBackColor = false;
			this.btnAddToList.Click += new System.EventHandler(this.BtnAddToListClick);
			// 
			// btnDecQty
			// 
			this.btnDecQty.BackColor = System.Drawing.Color.LightPink;
			this.btnDecQty.BackgroundColor = System.Drawing.Color.LightPink;
			this.btnDecQty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecQty.BackgroundImage")));
			this.btnDecQty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnDecQty.BorderColor = System.Drawing.Color.Tomato;
			this.btnDecQty.BorderRadius = 9;
			this.btnDecQty.BorderSize = 0;
			this.btnDecQty.FlatAppearance.BorderSize = 0;
			this.btnDecQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDecQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.btnDecQty.ForeColor = System.Drawing.Color.White;
			this.btnDecQty.Location = new System.Drawing.Point(21, 144);
			this.btnDecQty.Name = "btnDecQty";
			this.btnDecQty.Size = new System.Drawing.Size(20, 20);
			this.btnDecQty.TabIndex = 3;
			this.btnDecQty.TextColor = System.Drawing.Color.White;
			this.btnDecQty.UseVisualStyleBackColor = true;
			this.btnDecQty.Click += new System.EventHandler(this.BtnDecQtyClick);
			// 
			// btnIncQty
			// 
			this.btnIncQty.BackColor = System.Drawing.Color.LightPink;
			this.btnIncQty.BackgroundColor = System.Drawing.Color.LightPink;
			this.btnIncQty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncQty.BackgroundImage")));
			this.btnIncQty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnIncQty.BorderColor = System.Drawing.Color.Tomato;
			this.btnIncQty.BorderRadius = 9;
			this.btnIncQty.BorderSize = 0;
			this.btnIncQty.FlatAppearance.BorderSize = 0;
			this.btnIncQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIncQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.btnIncQty.ForeColor = System.Drawing.Color.White;
			this.btnIncQty.Location = new System.Drawing.Point(133, 144);
			this.btnIncQty.Name = "btnIncQty";
			this.btnIncQty.Size = new System.Drawing.Size(20, 20);
			this.btnIncQty.TabIndex = 2;
			this.btnIncQty.TextColor = System.Drawing.Color.White;
			this.btnIncQty.UseVisualStyleBackColor = true;
			this.btnIncQty.Click += new System.EventHandler(this.BtnIncQtyClick);
			// 
			// txtProductQty
			// 
			this.txtProductQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtProductQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.txtProductQty.Location = new System.Drawing.Point(47, 144);
			this.txtProductQty.Name = "txtProductQty";
			this.txtProductQty.Size = new System.Drawing.Size(77, 22);
			this.txtProductQty.TabIndex = 1;
			this.txtProductQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.White;
			this.panel5.Controls.Add(this.lblProductName);
			this.panel5.Controls.Add(this.pbProductPic);
			this.panel5.Controls.Add(this.lblProductPrice);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(173, 135);
			this.panel5.TabIndex = 0;
			// 
			// lblProductName
			// 
			this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProductName.Location = new System.Drawing.Point(-3, 0);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(177, 23);
			this.lblProductName.TabIndex = 5;
			this.lblProductName.Text = "LG OLED TV 65\"";
			this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pbProductPic
			// 
			this.pbProductPic.BackColor = System.Drawing.Color.Transparent;
			this.pbProductPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbProductPic.Location = new System.Drawing.Point(21, 26);
			this.pbProductPic.Name = "pbProductPic";
			this.pbProductPic.Size = new System.Drawing.Size(128, 78);
			this.pbProductPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbProductPic.TabIndex = 7;
			this.pbProductPic.TabStop = false;
			// 
			// lblProductPrice
			// 
			this.lblProductPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProductPrice.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblProductPrice.Location = new System.Drawing.Point(3, 107);
			this.lblProductPrice.Name = "lblProductPrice";
			this.lblProductPrice.Size = new System.Drawing.Size(167, 24);
			this.lblProductPrice.TabIndex = 6;
			this.lblProductPrice.Text = "66,990";
			this.lblProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ProductCard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel4);
			this.Name = "ProductCard";
			this.Size = new System.Drawing.Size(180, 220);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbProductPic)).EndInit();
			this.ResumeLayout(false);
		}
		private termProject.RoundedButton btnAddToList;
		private termProject.RoundedButton btnDecQty;
		private termProject.RoundedButton btnIncQty;
		private System.Windows.Forms.TextBox txtProductQty;
		private System.Windows.Forms.Label lblProductName;
		private System.Windows.Forms.PictureBox pbProductPic;
		private System.Windows.Forms.Label lblProductPrice;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		
		
	}
}
