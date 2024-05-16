namespace AdminPanel.Forms.User
{
    partial class Frm_ViewUser
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
            this.NameText = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailText = new RJCodeAdvance.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.NameText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.NameText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.NameText.BorderRadius = 15;
            this.NameText.BorderSize = 2;
            this.NameText.Enabled = false;
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameText.Location = new System.Drawing.Point(78, 20);
            this.NameText.Margin = new System.Windows.Forms.Padding(4);
            this.NameText.Multiline = false;
            this.NameText.Name = "NameText";
            this.NameText.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.NameText.PasswordChar = false;
            this.NameText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.NameText.PlaceholderText = "";
            this.NameText.Size = new System.Drawing.Size(245, 31);
            this.NameText.TabIndex = 0;
            this.NameText.Texts = "";
            this.NameText.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label2.Font = new System.Drawing.Font("Impact", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label3.Font = new System.Drawing.Font("Impact", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // EmailText
            // 
            this.EmailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.EmailText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.EmailText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.EmailText.BorderRadius = 15;
            this.EmailText.BorderSize = 2;
            this.EmailText.Enabled = false;
            this.EmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmailText.Location = new System.Drawing.Point(78, 60);
            this.EmailText.Margin = new System.Windows.Forms.Padding(4);
            this.EmailText.Multiline = false;
            this.EmailText.Name = "EmailText";
            this.EmailText.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.EmailText.PasswordChar = false;
            this.EmailText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.EmailText.PlaceholderText = "";
            this.EmailText.Size = new System.Drawing.Size(245, 31);
            this.EmailText.TabIndex = 28;
            this.EmailText.Texts = "";
            this.EmailText.UnderlinedStyle = false;
            this.EmailText._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            // 
            // Frm_ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(375, 114);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameText);
            this.Name = "Frm_ViewUser";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Frm_ViewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJTextBox NameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJTextBox EmailText;
    }
}