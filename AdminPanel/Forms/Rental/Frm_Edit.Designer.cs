namespace AdminPanel.Forms.Rental
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
            this.ComboStatus = new RJCodeAdvance.RJControls.RJComboBox();
            this.PaymentCombo = new RJCodeAdvance.RJControls.RJComboBox();
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
            this.EditBtn.Location = new System.Drawing.Point(12, 127);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(269, 40);
            this.EditBtn.TabIndex = 15;
            this.EditBtn.Text = "Edit";
            this.EditBtn.TextColor = System.Drawing.Color.White;
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ComboStatus
            // 
            this.ComboStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ComboStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ComboStatus.BorderSize = 0;
            this.ComboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ComboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ComboStatus.ForeColor = System.Drawing.Color.DarkGray;
            this.ComboStatus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ComboStatus.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ComboStatus.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ComboStatus.Location = new System.Drawing.Point(12, 30);
            this.ComboStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboStatus.Name = "ComboStatus";
            this.ComboStatus.Size = new System.Drawing.Size(269, 35);
            this.ComboStatus.TabIndex = 25;
            this.ComboStatus.Texts = "Select Rental Status";
            // 
            // PaymentCombo
            // 
            this.PaymentCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PaymentCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PaymentCombo.BorderSize = 0;
            this.PaymentCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.PaymentCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PaymentCombo.ForeColor = System.Drawing.Color.DarkGray;
            this.PaymentCombo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.PaymentCombo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PaymentCombo.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.PaymentCombo.Location = new System.Drawing.Point(12, 74);
            this.PaymentCombo.MinimumSize = new System.Drawing.Size(200, 30);
            this.PaymentCombo.Name = "PaymentCombo";
            this.PaymentCombo.Size = new System.Drawing.Size(269, 35);
            this.PaymentCombo.TabIndex = 83;
            this.PaymentCombo.Texts = "Select Payment Status";
            // 
            // Frm_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(301, 178);
            this.Controls.Add(this.PaymentCombo);
            this.Controls.Add(this.ComboStatus);
            this.Controls.Add(this.EditBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Edit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Rental";
            this.Load += new System.EventHandler(this.Frm_Edit_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private RJCodeAdvance.RJControls.RJButton EditBtn;
        private RJCodeAdvance.RJControls.RJComboBox ComboStatus;
        private RJCodeAdvance.RJControls.RJComboBox PaymentCombo;
    }
}