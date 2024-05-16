namespace AdminPanel.Forms.Color
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
            this.ColorText = new RJCodeAdvance.RJControls.RJTextBox();
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
            this.EditBtn.Location = new System.Drawing.Point(64, 110);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(248, 62);
            this.EditBtn.TabIndex = 15;
            this.EditBtn.Text = "Edit Color";
            this.EditBtn.TextColor = System.Drawing.Color.White;
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // BrandText
            // 
            this.ColorText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ColorText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ColorText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ColorText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ColorText.BorderRadius = 10;
            this.ColorText.BorderSize = 1;
            this.ColorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ColorText.Location = new System.Drawing.Point(27, 55);
            this.ColorText.Margin = new System.Windows.Forms.Padding(4);
            this.ColorText.Multiline = false;
            this.ColorText.Name = "BrandText";
            this.ColorText.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ColorText.PasswordChar = false;
            this.ColorText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ColorText.PlaceholderText = "";
            this.ColorText.Size = new System.Drawing.Size(334, 39);
            this.ColorText.TabIndex = 16;
            this.ColorText.Texts = "";
            this.ColorText.UnderlinedStyle = false;
            // 
            // Frm_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(387, 195);
            this.Controls.Add(this.ColorText);
            this.Controls.Add(this.EditBtn);
            this.Name = "Frm_Edit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Color";
            this.Load += new System.EventHandler(this.Frm_Edit_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private RJCodeAdvance.RJControls.RJButton EditBtn;
        private RJCodeAdvance.RJControls.RJTextBox ColorText;
    }
}