namespace AdminPanel.Forms.Auth
{
    partial class Frm_Login
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
			this.label1 = new System.Windows.Forms.Label();
			this.LogBtn = new RJCodeAdvance.RJControls.RJButton();
			this.EmailText = new RJCodeAdvance.RJControls.RJTextBox();
			this.PassText = new RJCodeAdvance.RJControls.RJTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
			this.label1.Location = new System.Drawing.Point(156, 33);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "Admin Panel Login";
			// 
			// LogBtn
			// 
			this.LogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
			this.LogBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
			this.LogBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.LogBtn.BorderRadius = 15;
			this.LogBtn.BorderSize = 0;
			this.LogBtn.FlatAppearance.BorderSize = 0;
			this.LogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LogBtn.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LogBtn.ForeColor = System.Drawing.Color.White;
			this.LogBtn.Location = new System.Drawing.Point(109, 196);
			this.LogBtn.Name = "LogBtn";
			this.LogBtn.Size = new System.Drawing.Size(258, 50);
			this.LogBtn.TabIndex = 13;
			this.LogBtn.Text = "Log in";
			this.LogBtn.TextColor = System.Drawing.Color.White;
			this.LogBtn.UseVisualStyleBackColor = false;
			this.LogBtn.Click += new System.EventHandler(this.LoginBtn_Click);
			// 
			// EmailText
			// 
			this.EmailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.EmailText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.EmailText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.EmailText.BorderRadius = 10;
			this.EmailText.BorderSize = 1;
			this.EmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EmailText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
			this.EmailText.Location = new System.Drawing.Point(40, 84);
			this.EmailText.Margin = new System.Windows.Forms.Padding(4);
			this.EmailText.Multiline = false;
			this.EmailText.Name = "EmailText";
			this.EmailText.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.EmailText.PasswordChar = false;
			this.EmailText.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.EmailText.PlaceholderText = "Email";
			this.EmailText.Size = new System.Drawing.Size(412, 31);
			this.EmailText.TabIndex = 17;
			this.EmailText.Texts = "";
			this.EmailText.UnderlinedStyle = false;
			// 
			// PassText
			// 
			this.PassText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.PassText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.PassText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.PassText.BorderRadius = 10;
			this.PassText.BorderSize = 1;
			this.PassText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PassText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
			this.PassText.Location = new System.Drawing.Point(40, 142);
			this.PassText.Margin = new System.Windows.Forms.Padding(4);
			this.PassText.Multiline = false;
			this.PassText.Name = "PassText";
			this.PassText.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.PassText.PasswordChar = false;
			this.PassText.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.PassText.PlaceholderText = "Password";
			this.PassText.Size = new System.Drawing.Size(412, 31);
			this.PassText.TabIndex = 18;
			this.PassText.Texts = "";
			this.PassText.UnderlinedStyle = false;
			// 
			// Frm_Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(482, 258);
			this.Controls.Add(this.PassText);
			this.Controls.Add(this.EmailText);
			this.Controls.Add(this.LogBtn);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.Name = "Frm_Login";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Frm_Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJButton LogBtn;
        private RJCodeAdvance.RJControls.RJTextBox EmailText;
        private RJCodeAdvance.RJControls.RJTextBox PassText;
    }
}