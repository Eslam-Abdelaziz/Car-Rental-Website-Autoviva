namespace AdminPanel.Forms.Car
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
            this.ModelYearText = new RJCodeAdvance.RJControls.RJTextBox();
            this.BrandCombo = new RJCodeAdvance.RJControls.RJComboBox();
            this.SeatsText = new RJCodeAdvance.RJControls.RJTextBox();
            this.SizeCombo = new RJCodeAdvance.RJControls.RJComboBox();
            this.IsElectricToggle = new RJCodeAdvance.RJControls.RJToggleButton();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.BranchCombo = new RJCodeAdvance.RJControls.RJComboBox();
            this.PriceText = new RJCodeAdvance.RJControls.RJTextBox();
            this.ChooseBtn = new RJCodeAdvance.RJControls.RJButton();
            this.ColorCombo = new RJCodeAdvance.RJControls.RJComboBox();
            this.ModelCombo = new RJCodeAdvance.RJControls.RJComboBox();
            this.CarView = new AdminPanel.UI.CarView();
            this.label1 = new System.Windows.Forms.Label();
            this.IsAutomaticToggle = new RJCodeAdvance.RJControls.RJToggleButton();
            this.FuelUsageText = new RJCodeAdvance.RJControls.RJTextBox();
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
            this.AddBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(21, 835);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(271, 40);
            this.AddBtn.TabIndex = 15;
            this.AddBtn.Text = "Add ";
            this.AddBtn.TextColor = System.Drawing.Color.White;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ModelYearText
            // 
            this.ModelYearText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ModelYearText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ModelYearText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ModelYearText.BorderRadius = 10;
            this.ModelYearText.BorderSize = 1;
            this.ModelYearText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelYearText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ModelYearText.Location = new System.Drawing.Point(363, 597);
            this.ModelYearText.Margin = new System.Windows.Forms.Padding(4);
            this.ModelYearText.Multiline = false;
            this.ModelYearText.Name = "ModelYearText";
            this.ModelYearText.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.ModelYearText.PasswordChar = false;
            this.ModelYearText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ModelYearText.PlaceholderText = "Model Year";
            this.ModelYearText.Size = new System.Drawing.Size(213, 27);
            this.ModelYearText.TabIndex = 20;
            this.ModelYearText.Texts = "";
            this.ModelYearText.UnderlinedStyle = false;
            this.ModelYearText._TextChanged += new System.EventHandler(this.ModelYearText__TextChanged);
            this.ModelYearText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModelYearText_KeyPress);
            // 
            // BrandCombo
            // 
            this.BrandCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BrandCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BrandCombo.BorderSize = 0;
            this.BrandCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.BrandCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BrandCombo.ForeColor = System.Drawing.Color.DarkGray;
            this.BrandCombo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.BrandCombo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BrandCombo.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.BrandCombo.Location = new System.Drawing.Point(23, 542);
            this.BrandCombo.MinimumSize = new System.Drawing.Size(200, 30);
            this.BrandCombo.Name = "BrandCombo";
            this.BrandCombo.Size = new System.Drawing.Size(269, 35);
            this.BrandCombo.TabIndex = 24;
            this.BrandCombo.Texts = "Select Brand";
            this.BrandCombo.OnSelectedIndexChanged += new System.EventHandler(this.BrandCombo_OnSelectedIndexChanged);
            // 
            // SeatsText
            // 
            this.SeatsText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.SeatsText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.SeatsText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.SeatsText.BorderRadius = 10;
            this.SeatsText.BorderSize = 1;
            this.SeatsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.SeatsText.Location = new System.Drawing.Point(363, 701);
            this.SeatsText.Margin = new System.Windows.Forms.Padding(4);
            this.SeatsText.Multiline = false;
            this.SeatsText.Name = "SeatsText";
            this.SeatsText.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.SeatsText.PasswordChar = false;
            this.SeatsText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.SeatsText.PlaceholderText = "Seats Number ";
            this.SeatsText.Size = new System.Drawing.Size(213, 27);
            this.SeatsText.TabIndex = 25;
            this.SeatsText.Texts = "";
            this.SeatsText.UnderlinedStyle = false;
            this.SeatsText._TextChanged += new System.EventHandler(this.SeatsText__TextChanged);
            this.SeatsText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SeatsText_KeyPress);
            // 
            // SizeCombo
            // 
            this.SizeCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.SizeCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.SizeCombo.BorderSize = 0;
            this.SizeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.SizeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SizeCombo.ForeColor = System.Drawing.Color.DarkGray;
            this.SizeCombo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.SizeCombo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.SizeCombo.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.SizeCombo.Location = new System.Drawing.Point(23, 649);
            this.SizeCombo.MinimumSize = new System.Drawing.Size(200, 30);
            this.SizeCombo.Name = "SizeCombo";
            this.SizeCombo.Size = new System.Drawing.Size(270, 35);
            this.SizeCombo.TabIndex = 26;
            this.SizeCombo.Texts = "Select Car Size";
            this.SizeCombo.OnSelectedIndexChanged += new System.EventHandler(this.SizeCombo_OnSelectedIndexChanged);
            // 
            // IsElectricToggle
            // 
            this.IsElectricToggle.AutoSize = true;
            this.IsElectricToggle.Location = new System.Drawing.Point(200, 758);
            this.IsElectricToggle.MinimumSize = new System.Drawing.Size(80, 30);
            this.IsElectricToggle.Name = "IsElectricToggle";
            this.IsElectricToggle.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.IsElectricToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.IsElectricToggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.IsElectricToggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.IsElectricToggle.Size = new System.Drawing.Size(80, 30);
            this.IsElectricToggle.TabIndex = 27;
            this.IsElectricToggle.UseVisualStyleBackColor = true;
            this.IsElectricToggle.CheckedChanged += new System.EventHandler(this.IsElectricToggle_CheckedChanged);
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.ForeColor = System.Drawing.Color.DarkGray;
            this.PriceLbl.Location = new System.Drawing.Point(19, 761);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(90, 20);
            this.PriceLbl.TabIndex = 28;
            this.PriceLbl.Text = "Is Electric : ";
            // 
            // BranchCombo
            // 
            this.BranchCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BranchCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BranchCombo.BorderSize = 0;
            this.BranchCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.BranchCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BranchCombo.ForeColor = System.Drawing.Color.DarkGray;
            this.BranchCombo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.BranchCombo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BranchCombo.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.BranchCombo.Location = new System.Drawing.Point(363, 649);
            this.BranchCombo.MinimumSize = new System.Drawing.Size(200, 30);
            this.BranchCombo.Name = "BranchCombo";
            this.BranchCombo.Size = new System.Drawing.Size(213, 35);
            this.BranchCombo.TabIndex = 29;
            this.BranchCombo.Texts = "Select Branch";
            this.BranchCombo.OnSelectedIndexChanged += new System.EventHandler(this.BranchCombo_OnSelectedIndexChanged);
            // 
            // PriceText
            // 
            this.PriceText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PriceText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PriceText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PriceText.BorderRadius = 10;
            this.PriceText.BorderSize = 1;
            this.PriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.PriceText.Location = new System.Drawing.Point(361, 758);
            this.PriceText.Margin = new System.Windows.Forms.Padding(4);
            this.PriceText.Multiline = false;
            this.PriceText.Name = "PriceText";
            this.PriceText.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.PriceText.PasswordChar = false;
            this.PriceText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.PriceText.PlaceholderText = "Daily Price";
            this.PriceText.Size = new System.Drawing.Size(215, 27);
            this.PriceText.TabIndex = 30;
            this.PriceText.Texts = "";
            this.PriceText.UnderlinedStyle = false;
            this.PriceText._TextChanged += new System.EventHandler(this.PriceText__TextChanged);
            this.PriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceText_KeyPress);
            // 
            // ChooseBtn
            // 
            this.ChooseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ChooseBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ChooseBtn.BorderColor = System.Drawing.Color.Pink;
            this.ChooseBtn.BorderRadius = 15;
            this.ChooseBtn.BorderSize = 0;
            this.ChooseBtn.FlatAppearance.BorderSize = 0;
            this.ChooseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseBtn.ForeColor = System.Drawing.Color.White;
            this.ChooseBtn.Location = new System.Drawing.Point(363, 835);
            this.ChooseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ChooseBtn.Name = "ChooseBtn";
            this.ChooseBtn.Size = new System.Drawing.Size(213, 40);
            this.ChooseBtn.TabIndex = 31;
            this.ChooseBtn.Text = "Choose Images";
            this.ChooseBtn.TextColor = System.Drawing.Color.White;
            this.ChooseBtn.UseVisualStyleBackColor = false;
            this.ChooseBtn.Click += new System.EventHandler(this.ChooseBtn_Click);
            // 
            // ColorCombo
            // 
            this.ColorCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ColorCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ColorCombo.BorderSize = 0;
            this.ColorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ColorCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ColorCombo.ForeColor = System.Drawing.Color.DarkGray;
            this.ColorCombo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ColorCombo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ColorCombo.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ColorCombo.Location = new System.Drawing.Point(363, 542);
            this.ColorCombo.MinimumSize = new System.Drawing.Size(200, 30);
            this.ColorCombo.Name = "ColorCombo";
            this.ColorCombo.Size = new System.Drawing.Size(213, 35);
            this.ColorCombo.TabIndex = 32;
            this.ColorCombo.Texts = "Select Color";
            this.ColorCombo.OnSelectedIndexChanged += new System.EventHandler(this.ColorCombo_OnSelectedIndexChanged);
            // 
            // ModelCombo
            // 
            this.ModelCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ModelCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ModelCombo.BorderSize = 0;
            this.ModelCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ModelCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ModelCombo.ForeColor = System.Drawing.Color.DarkGray;
            this.ModelCombo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ModelCombo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ModelCombo.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ModelCombo.Location = new System.Drawing.Point(23, 589);
            this.ModelCombo.MinimumSize = new System.Drawing.Size(200, 30);
            this.ModelCombo.Name = "ModelCombo";
            this.ModelCombo.Size = new System.Drawing.Size(270, 35);
            this.ModelCombo.TabIndex = 33;
            this.ModelCombo.Texts = "Select Model";
            this.ModelCombo.OnSelectedIndexChanged += new System.EventHandler(this.ModelCombo_OnSelectedIndexChanged);
            // 
            // CarView
            // 
            this.CarView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.CarView.Location = new System.Drawing.Point(12, 12);
            this.CarView.MinimumSize = new System.Drawing.Size(547, 469);
            this.CarView.Name = "CarView";
            this.CarView.Size = new System.Drawing.Size(564, 511);
            this.CarView.TabIndex = 22;
            this.CarView.Load += new System.EventHandler(this.CarView_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(19, 801);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Is Automatic : ";
            // 
            // IsAutomaticToggle
            // 
            this.IsAutomaticToggle.AutoSize = true;
            this.IsAutomaticToggle.Location = new System.Drawing.Point(200, 798);
            this.IsAutomaticToggle.MinimumSize = new System.Drawing.Size(80, 30);
            this.IsAutomaticToggle.Name = "IsAutomaticToggle";
            this.IsAutomaticToggle.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.IsAutomaticToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.IsAutomaticToggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.IsAutomaticToggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.IsAutomaticToggle.Size = new System.Drawing.Size(80, 30);
            this.IsAutomaticToggle.TabIndex = 34;
            this.IsAutomaticToggle.UseVisualStyleBackColor = true;
            this.IsAutomaticToggle.CheckedChanged += new System.EventHandler(this.IsAutomaticToggle_CheckedChanged);
            // 
            // FuelUsageText
            // 
            this.FuelUsageText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.FuelUsageText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.FuelUsageText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.FuelUsageText.BorderRadius = 10;
            this.FuelUsageText.BorderSize = 1;
            this.FuelUsageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuelUsageText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.FuelUsageText.Location = new System.Drawing.Point(23, 701);
            this.FuelUsageText.Margin = new System.Windows.Forms.Padding(4);
            this.FuelUsageText.Multiline = false;
            this.FuelUsageText.Name = "FuelUsageText";
            this.FuelUsageText.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.FuelUsageText.PasswordChar = false;
            this.FuelUsageText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.FuelUsageText.PlaceholderText = "Fuel Usage";
            this.FuelUsageText.Size = new System.Drawing.Size(270, 27);
            this.FuelUsageText.TabIndex = 36;
            this.FuelUsageText.Texts = "";
            this.FuelUsageText.UnderlinedStyle = false;
            this.FuelUsageText._TextChanged += new System.EventHandler(this.FuelUsageText__TextChanged);
            this.FuelUsageText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FuelUsageText_KeyPress);
            // 
            // Frm_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(591, 909);
            this.Controls.Add(this.FuelUsageText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsAutomaticToggle);
            this.Controls.Add(this.ModelCombo);
            this.Controls.Add(this.ColorCombo);
            this.Controls.Add(this.ChooseBtn);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.BranchCombo);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.IsElectricToggle);
            this.Controls.Add(this.SizeCombo);
            this.Controls.Add(this.SeatsText);
            this.Controls.Add(this.BrandCombo);
            this.Controls.Add(this.CarView);
            this.Controls.Add(this.ModelYearText);
            this.Controls.Add(this.AddBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Car";
            this.Load += new System.EventHandler(this.Frm_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RJCodeAdvance.RJControls.RJButton AddBtn;
        private RJCodeAdvance.RJControls.RJTextBox ModelYearText;
        private UI.CarView CarView;
        private RJCodeAdvance.RJControls.RJComboBox BrandCombo;
        private RJCodeAdvance.RJControls.RJTextBox SeatsText;
        private RJCodeAdvance.RJControls.RJComboBox SizeCombo;
        private System.Windows.Forms.Label PriceLbl;
        private RJCodeAdvance.RJControls.RJComboBox BranchCombo;
        private RJCodeAdvance.RJControls.RJTextBox PriceText;
        private RJCodeAdvance.RJControls.RJButton ChooseBtn;
        private RJCodeAdvance.RJControls.RJComboBox ColorCombo;
        private RJCodeAdvance.RJControls.RJToggleButton IsElectricToggle;
        private RJCodeAdvance.RJControls.RJComboBox ModelCombo;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJToggleButton IsAutomaticToggle;
        private RJCodeAdvance.RJControls.RJTextBox FuelUsageText;
    }
}