namespace AdminPanel.Forms.Brand
{
    partial class Frm_Edit
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
            this.EditBtn = new RJCodeAdvance.RJControls.RJButton();
            this.BrandText = new RJCodeAdvance.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.EditBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.EditBtn.BorderColor = System.Drawing.Color.Pink;
            this.EditBtn.BorderRadius = 15;
            this.EditBtn.BorderSize = 0;
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(59, 81);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(238, 40);
            this.EditBtn.TabIndex = 15;
            this.EditBtn.Text = "Edit Brand";
            this.EditBtn.TextColor = System.Drawing.Color.White;
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // BrandText
            // 
            this.BrandText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BrandText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BrandText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BrandText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BrandText.BorderRadius = 10;
            this.BrandText.BorderSize = 1;
            this.BrandText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.BrandText.Location = new System.Drawing.Point(33, 37);
            this.BrandText.Multiline = false;
            this.BrandText.Name = "BrandText";
            this.BrandText.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BrandText.PasswordChar = false;
            this.BrandText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.BrandText.PlaceholderText = "Brand Name";
            this.BrandText.Size = new System.Drawing.Size(299, 27);
            this.BrandText.TabIndex = 16;
            this.BrandText.Texts = "";
            this.BrandText.UnderlinedStyle = false;
            // 
            // Frm_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(376, 145);
            this.Controls.Add(this.BrandText);
            this.Controls.Add(this.EditBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Edit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Brand";
            this.Load += new System.EventHandler(this.Frm_Edit_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private RJCodeAdvance.RJControls.RJButton EditBtn;
        private RJCodeAdvance.RJControls.RJTextBox BrandText;
    }
}