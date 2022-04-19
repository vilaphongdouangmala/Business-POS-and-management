/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 26-Mar-22
 * Time: 1:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace termProject
{
	partial class FrmRegister
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
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtConfirm = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.btnCancel = new termProject.RoundedButton();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblEmployeeName = new System.Windows.Forms.Label();
			this.btnCreate = new termProject.RoundedButton();
			this.txtEmployeeId = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(52, 106);
			this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(331, 41);
			this.label6.TabIndex = 45;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label7.Location = new System.Drawing.Point(48, 84);
			this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(124, 35);
			this.label7.TabIndex = 44;
			this.label7.Text = "EmployeeId";
			// 
			// txtConfirm
			// 
			this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtConfirm.Location = new System.Drawing.Point(58, 434);
			this.txtConfirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.txtConfirm.Name = "txtConfirm";
			this.txtConfirm.Size = new System.Drawing.Size(317, 19);
			this.txtConfirm.TabIndex = 38;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(52, 423);
			this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(331, 41);
			this.label4.TabIndex = 41;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label5.Location = new System.Drawing.Point(48, 401);
			this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(190, 35);
			this.label5.TabIndex = 43;
			this.label5.Text = "Confirm Password";
			// 
			// txtPassword
			// 
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtPassword.Location = new System.Drawing.Point(58, 351);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(317, 19);
			this.txtPassword.TabIndex = 37;
			// 
			// txtUsername
			// 
			this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtUsername.Location = new System.Drawing.Point(58, 269);
			this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(317, 19);
			this.txtUsername.TabIndex = 35;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(52, 259);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(331, 41);
			this.label2.TabIndex = 38;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(52, 340);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(331, 41);
			this.label1.TabIndex = 36;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label3.Location = new System.Drawing.Point(48, 318);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 35);
			this.label3.TabIndex = 39;
			this.label3.Text = "Password";
			// 
			// lblUsername
			// 
			this.lblUsername.BackColor = System.Drawing.Color.White;
			this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblUsername.Location = new System.Drawing.Point(48, 237);
			this.lblUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(124, 35);
			this.lblUsername.TabIndex = 34;
			this.lblUsername.Text = "Username";
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Brown;
			this.btnCancel.BackgroundColor = System.Drawing.Color.Brown;
			this.btnCancel.BorderColor = System.Drawing.Color.Tomato;
			this.btnCancel.BorderRadius = 15;
			this.btnCancel.BorderSize = 0;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(229, 484);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(70, 32);
			this.btnCancel.TabIndex = 46;
			this.btnCancel.Text = "Close";
			this.btnCancel.TextColor = System.Drawing.Color.White;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(28, 30);
			this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(313, 45);
			this.label8.TabIndex = 47;
			this.label8.Text = "Create an Account";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label9.Location = new System.Drawing.Point(48, 157);
			this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(74, 20);
			this.label9.TabIndex = 48;
			this.label9.Text = "Name:";
			// 
			// lblEmployeeName
			// 
			this.lblEmployeeName.BackColor = System.Drawing.Color.White;
			this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmployeeName.Location = new System.Drawing.Point(52, 186);
			this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblEmployeeName.Name = "lblEmployeeName";
			this.lblEmployeeName.Size = new System.Drawing.Size(331, 24);
			this.lblEmployeeName.TabIndex = 49;
			this.lblEmployeeName.Text = "-";
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.Color.Brown;
			this.btnCreate.BackgroundColor = System.Drawing.Color.Brown;
			this.btnCreate.BorderColor = System.Drawing.Color.Tomato;
			this.btnCreate.BorderRadius = 15;
			this.btnCreate.BorderSize = 0;
			this.btnCreate.FlatAppearance.BorderSize = 0;
			this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnCreate.ForeColor = System.Drawing.Color.White;
			this.btnCreate.Location = new System.Drawing.Point(313, 484);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(70, 32);
			this.btnCreate.TabIndex = 40;
			this.btnCreate.Text = "Create";
			this.btnCreate.TextColor = System.Drawing.Color.White;
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.BtnCreateClick);
			// 
			// txtEmployeeId
			// 
			this.txtEmployeeId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtEmployeeId.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtEmployeeId.Location = new System.Drawing.Point(58, 117);
			this.txtEmployeeId.Margin = new System.Windows.Forms.Padding(2);
			this.txtEmployeeId.Name = "txtEmployeeId";
			this.txtEmployeeId.Size = new System.Drawing.Size(317, 19);
			this.txtEmployeeId.TabIndex = 86;
			this.txtEmployeeId.TextChanged += new System.EventHandler(this.TxtEmployeeIdTextChanged);
			// 
			// FrmRegister
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(439, 535);
			this.Controls.Add(this.txtEmployeeId);
			this.Controls.Add(this.lblEmployeeName);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtConfirm);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblUsername);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FrmRegister";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmRegister";
			this.Load += new System.EventHandler(this.FrmRegisterLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblEmployeeName;
		private System.Windows.Forms.Label label9;
		private termProject.RoundedButton btnCancel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUsername;
		private termProject.RoundedButton btnCreate;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtConfirm;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtEmployeeId;
	}
}
