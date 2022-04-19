/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 08-Feb-22
 * Time: 10:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace termProject
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
        	this.lblUsername = new System.Windows.Forms.Label();
        	this.txtUsername = new System.Windows.Forms.TextBox();
        	this.txtPassword = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.btnLogin = new termProject.RoundedButton();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.lblCreateUser = new System.Windows.Forms.Label();
        	this.pnlInteractingUI = new System.Windows.Forms.Panel();
        	this.pictureBox2 = new System.Windows.Forms.PictureBox();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.pnlInteractingUI.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// lblUsername
        	// 
        	this.lblUsername.BackColor = System.Drawing.Color.White;
        	this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.lblUsername.Location = new System.Drawing.Point(520, 229);
        	this.lblUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
        	this.lblUsername.Name = "lblUsername";
        	this.lblUsername.Size = new System.Drawing.Size(124, 35);
        	this.lblUsername.TabIndex = 0;
        	this.lblUsername.Text = "Username";
        	// 
        	// txtUsername
        	// 
        	this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
        	this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.txtUsername.Location = new System.Drawing.Point(530, 261);
        	this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        	this.txtUsername.Name = "txtUsername";
        	this.txtUsername.Size = new System.Drawing.Size(317, 19);
        	this.txtUsername.TabIndex = 1;
        	// 
        	// txtPassword
        	// 
        	this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
        	this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.txtPassword.Location = new System.Drawing.Point(532, 343);
        	this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        	this.txtPassword.Name = "txtPassword";
        	this.txtPassword.Size = new System.Drawing.Size(315, 19);
        	this.txtPassword.TabIndex = 3;
        	// 
        	// label1
        	// 
        	this.label1.BackColor = System.Drawing.Color.White;
        	this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(524, 332);
        	this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(331, 41);
        	this.label1.TabIndex = 2;
        	// 
        	// label2
        	// 
        	this.label2.BackColor = System.Drawing.Color.White;
        	this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.Location = new System.Drawing.Point(524, 251);
        	this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(331, 41);
        	this.label2.TabIndex = 7;
        	// 
        	// btnLogin
        	// 
        	this.btnLogin.BackColor = System.Drawing.Color.Brown;
        	this.btnLogin.BackgroundColor = System.Drawing.Color.Brown;
        	this.btnLogin.BorderColor = System.Drawing.Color.Tomato;
        	this.btnLogin.BorderRadius = 15;
        	this.btnLogin.BorderSize = 0;
        	this.btnLogin.FlatAppearance.BorderSize = 0;
        	this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        	this.btnLogin.ForeColor = System.Drawing.Color.White;
        	this.btnLogin.Location = new System.Drawing.Point(629, 401);
        	this.btnLogin.Name = "btnLogin";
        	this.btnLogin.Size = new System.Drawing.Size(124, 34);
        	this.btnLogin.TabIndex = 8;
        	this.btnLogin.Text = "LOGIN";
        	this.btnLogin.TextColor = System.Drawing.Color.White;
        	this.btnLogin.UseVisualStyleBackColor = false;
        	this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
        	this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.pictureBox1.Location = new System.Drawing.Point(0, 1);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(409, 560);
        	this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.pictureBox1.TabIndex = 9;
        	this.pictureBox1.TabStop = false;
        	// 
        	// label3
        	// 
        	this.label3.BackColor = System.Drawing.Color.White;
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.label3.Location = new System.Drawing.Point(520, 310);
        	this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(124, 35);
        	this.label3.TabIndex = 11;
        	this.label3.Text = "Password";
        	// 
        	// label4
        	// 
        	this.label4.BackColor = System.Drawing.Color.White;
        	this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.Location = new System.Drawing.Point(520, 144);
        	this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(215, 85);
        	this.label4.TabIndex = 12;
        	this.label4.Text = "Log in to your Account";
        	// 
        	// lblCreateUser
        	// 
        	this.lblCreateUser.BackColor = System.Drawing.Color.White;
        	this.lblCreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.lblCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblCreateUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
        	this.lblCreateUser.Location = new System.Drawing.Point(675, 375);
        	this.lblCreateUser.Name = "lblCreateUser";
        	this.lblCreateUser.Size = new System.Drawing.Size(180, 23);
        	this.lblCreateUser.TabIndex = 19;
        	this.lblCreateUser.Text = "Create a new user";
        	this.lblCreateUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.lblCreateUser.Click += new System.EventHandler(this.LblCreateUserClick);
        	// 
        	// pnlInteractingUI
        	// 
        	this.pnlInteractingUI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.pnlInteractingUI.Controls.Add(this.pictureBox2);
        	this.pnlInteractingUI.Location = new System.Drawing.Point(498, 64);
        	this.pnlInteractingUI.Name = "pnlInteractingUI";
        	this.pnlInteractingUI.Size = new System.Drawing.Size(391, 434);
        	this.pnlInteractingUI.TabIndex = 20;
        	// 
        	// pictureBox2
        	// 
        	this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
        	this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.pictureBox2.Location = new System.Drawing.Point(0, 0);
        	this.pictureBox2.Name = "pictureBox2";
        	this.pictureBox2.Size = new System.Drawing.Size(391, 434);
        	this.pictureBox2.TabIndex = 0;
        	this.pictureBox2.TabStop = false;
        	// 
        	// FrmLogin
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.SystemColors.Control;
        	this.ClientSize = new System.Drawing.Size(984, 561);
        	this.Controls.Add(this.lblCreateUser);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.txtUsername);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.txtPassword);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.pictureBox1);
        	this.Controls.Add(this.btnLogin);
        	this.Controls.Add(this.lblUsername);
        	this.Controls.Add(this.pnlInteractingUI);
        	this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.Margin = new System.Windows.Forms.Padding(6);
        	this.Name = "FrmLogin";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "FrmLogin";
        	this.Load += new System.EventHandler(this.FrmLogin_Load);
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.pnlInteractingUI.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlInteractingUI;
        private System.Windows.Forms.Label lblCreateUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private termProject.RoundedButton btnLogin;

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        
       
       
    }
}