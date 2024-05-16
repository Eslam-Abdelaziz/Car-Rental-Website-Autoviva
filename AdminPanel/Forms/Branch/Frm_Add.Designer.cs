namespace AdminPanel.Forms.Branch
{
    partial class Frm_Add
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
            this.AddBtn = new RJCodeAdvance.RJControls.RJButton();
            this.BranchText = new RJCodeAdvance.RJControls.RJTextBox();
            this.PhoneText = new RJCodeAdvance.RJControls.RJTextBox();
            this.StreetText = new RJCodeAdvance.RJControls.RJTextBox();
            this.CityText = new RJCodeAdvance.RJControls.RJTextBox();
            this.ZipCodeText = new RJCodeAdvance.RJControls.RJTextBox();
            this.StateText = new RJCodeAdvance.RJControls.RJTextBox();
            this.SuspendLayout();
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
            this.AddBtn.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(161, 150);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(165, 40);
            this.AddBtn.TabIndex = 15;
            this.AddBtn.Text = "Add Branch";
            this.AddBtn.TextColor = System.Drawing.Color.White;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // BranchText
            // 
            this.BranchText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BranchText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BranchText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BranchText.BorderRadius = 10;
            this.BranchText.BorderSize = 1;
            this.BranchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.BranchText.Location = new System.Drawing.Point(11, 20);
            this.BranchText.Multiline = false;
            this.BranchText.Name = "BranchText";
            this.BranchText.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BranchText.PasswordChar = false;
            this.BranchText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.BranchText.PlaceholderText = "Branch Name";
            this.BranchText.Size = new System.Drawing.Size(223, 35);
            this.BranchText.TabIndex = 16;
            this.BranchText.Texts = "";
            this.BranchText.UnderlinedStyle = false;
            // 
            // PhoneText
            // 
            this.PhoneText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PhoneText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PhoneText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PhoneText.BorderRadius = 10;
            this.PhoneText.BorderSize = 1;
            this.PhoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.PhoneText.Location = new System.Drawing.Point(11, 60);
            this.PhoneText.Multiline = false;
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.PhoneText.PasswordChar = false;
            this.PhoneText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.PhoneText.PlaceholderText = "Phone Number";
            this.PhoneText.Size = new System.Drawing.Size(223, 35);
            this.PhoneText.TabIndex = 17;
            this.PhoneText.Texts = "";
            this.PhoneText.UnderlinedStyle = false;
            // 
            // StreetText
            // 
            this.StreetText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.StreetText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.StreetText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.StreetText.BorderRadius = 10;
            this.StreetText.BorderSize = 1;
            this.StreetText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.StreetText.Location = new System.Drawing.Point(11, 103);
            this.StreetText.Multiline = false;
            this.StreetText.Name = "StreetText";
            this.StreetText.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.StreetText.PasswordChar = false;
            this.StreetText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.StreetText.PlaceholderText = "Street";
            this.StreetText.Size = new System.Drawing.Size(223, 35);
            this.StreetText.TabIndex = 18;
            this.StreetText.Texts = "";
            this.StreetText.UnderlinedStyle = false;
            // 
            // CityText
            // 
            this.CityText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.CityText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.CityText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.CityText.BorderRadius = 10;
            this.CityText.BorderSize = 1;
            this.CityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.CityText.Location = new System.Drawing.Point(257, 60);
            this.CityText.Multiline = false;
            this.CityText.Name = "CityText";
            this.CityText.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.CityText.PasswordChar = false;
            this.CityText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CityText.PlaceholderText = "City";
            this.CityText.Size = new System.Drawing.Size(213, 35);
            this.CityText.TabIndex = 19;
            this.CityText.Texts = "";
            this.CityText.UnderlinedStyle = false;
            // 
            // ZipCodeText
            // 
            this.ZipCodeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ZipCodeText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ZipCodeText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ZipCodeText.BorderRadius = 10;
            this.ZipCodeText.BorderSize = 1;
            this.ZipCodeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipCodeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ZipCodeText.Location = new System.Drawing.Point(257, 20);
            this.ZipCodeText.Multiline = false;
            this.ZipCodeText.Name = "ZipCodeText";
            this.ZipCodeText.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.ZipCodeText.PasswordChar = false;
            this.ZipCodeText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ZipCodeText.PlaceholderText = "ZipCode";
            this.ZipCodeText.Size = new System.Drawing.Size(213, 35);
            this.ZipCodeText.TabIndex = 20;
            this.ZipCodeText.Texts = "";
            this.ZipCodeText.UnderlinedStyle = false;
            // 
            // StateText
            // 
            this.StateText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.StateText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.StateText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.StateText.BorderRadius = 10;
            this.StateText.BorderSize = 1;
            this.StateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.StateText.Location = new System.Drawing.Point(257, 103);
            this.StateText.Multiline = false;
            this.StateText.Name = "StateText";
            this.StateText.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.StateText.PasswordChar = false;
            this.StateText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.StateText.PlaceholderText = "State";
            this.StateText.Size = new System.Drawing.Size(213, 35);
            this.StateText.TabIndex = 21;
            this.StateText.Texts = "";
            this.StateText.UnderlinedStyle = false;
            // 
            // Frm_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(479, 201);
            this.Controls.Add(this.StateText);
            this.Controls.Add(this.ZipCodeText);
            this.Controls.Add(this.CityText);
            this.Controls.Add(this.StreetText);
            this.Controls.Add(this.PhoneText);
            this.Controls.Add(this.BranchText);
            this.Controls.Add(this.AddBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Brand";
            this.ResumeLayout(false);

        }

        #endregion
        private RJCodeAdvance.RJControls.RJButton AddBtn;
        private RJCodeAdvance.RJControls.RJTextBox BranchText;
        private RJCodeAdvance.RJControls.RJTextBox PhoneText;
        private RJCodeAdvance.RJControls.RJTextBox StreetText;
        private RJCodeAdvance.RJControls.RJTextBox CityText;
        private RJCodeAdvance.RJControls.RJTextBox ZipCodeText;
        private RJCodeAdvance.RJControls.RJTextBox StateText;
    }
}