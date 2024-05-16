namespace AdminPanel.Forms.User
{
	partial class Frm_AddBranchControl
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
			this.lbl = new System.Windows.Forms.Label();
			this.AddBtn = new RJCodeAdvance.RJControls.RJButton();
			this.BranchCombo = new RJCodeAdvance.RJControls.RJComboBox();
			this.UserText = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl
			// 
			this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl.AutoSize = true;
			this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl.ForeColor = System.Drawing.Color.DarkGray;
			this.lbl.Location = new System.Drawing.Point(36, 20);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(69, 20);
			this.lbl.TabIndex = 81;
			this.lbl.Text = "User => ";
			// 
			// AddBtn
			// 
			this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
			this.AddBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
			this.AddBtn.BorderColor = System.Drawing.Color.Pink;
			this.AddBtn.BorderRadius = 15;
			this.AddBtn.BorderSize = 0;
			this.AddBtn.FlatAppearance.BorderSize = 0;
			this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddBtn.ForeColor = System.Drawing.Color.White;
			this.AddBtn.Location = new System.Drawing.Point(40, 110);
			this.AddBtn.Margin = new System.Windows.Forms.Padding(2);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(283, 40);
			this.AddBtn.TabIndex = 85;
			this.AddBtn.Text = "Add ";
			this.AddBtn.TextColor = System.Drawing.Color.White;
			this.AddBtn.UseVisualStyleBackColor = false;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// BranchCombo
			// 
			this.BranchCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BranchCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.BranchCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.BranchCombo.BorderSize = 0;
			this.BranchCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
			this.BranchCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.BranchCombo.ForeColor = System.Drawing.Color.DarkGray;
			this.BranchCombo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
			this.BranchCombo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.BranchCombo.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
			this.BranchCombo.Location = new System.Drawing.Point(40, 66);
			this.BranchCombo.MinimumSize = new System.Drawing.Size(150, 30);
			this.BranchCombo.Name = "BranchCombo";
			this.BranchCombo.Size = new System.Drawing.Size(283, 30);
			this.BranchCombo.TabIndex = 84;
			this.BranchCombo.Texts = "Select Branch";
			// 
			// UserText
			// 
			this.UserText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UserText.AutoSize = true;
			this.UserText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UserText.ForeColor = System.Drawing.Color.DarkGray;
			this.UserText.Location = new System.Drawing.Point(111, 20);
			this.UserText.Name = "UserText";
			this.UserText.Size = new System.Drawing.Size(0, 20);
			this.UserText.TabIndex = 86;
			// 
			// Frm_AddBranchControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(356, 163);
			this.Controls.Add(this.UserText);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.BranchCombo);
			this.Controls.Add(this.lbl);
			this.Name = "Frm_AddBranchControl";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Branch For User";
			this.Load += new System.EventHandler(this.Frm_AddBranchControl_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl;
		private RJCodeAdvance.RJControls.RJButton AddBtn;
		private RJCodeAdvance.RJControls.RJComboBox BranchCombo;
		private System.Windows.Forms.Label UserText;
	}
}