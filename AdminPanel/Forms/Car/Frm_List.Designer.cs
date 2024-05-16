using AdminPanel.UI;
using System.Windows.Forms;

namespace AdminPanel.Forms.Car
{
    partial class Frm_List
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.IsAutomatic = new RJCodeAdvance.RJControls.RJToggleButton();
            this.SizeCombo = new RJCodeAdvance.RJControls.RJComboBox();
            this.ModelYearText = new RJCodeAdvance.RJControls.RJTextBox();
            this.PriceText = new RJCodeAdvance.RJControls.RJTextBox();
            this.SeatsText = new RJCodeAdvance.RJControls.RJTextBox();
            this.NameText = new RJCodeAdvance.RJControls.RJTextBox();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.IsElectricToggle = new RJCodeAdvance.RJControls.RJToggleButton();
            this.ColorCombo = new RJCodeAdvance.RJControls.RJComboBox();
            this.BrandCombo = new RJCodeAdvance.RJControls.RJComboBox();
            this.BranchCombo = new RJCodeAdvance.RJControls.RJComboBox();
            this.EditBtn = new RJCodeAdvance.RJControls.RJButton();
            this.LogBtn = new RJCodeAdvance.RJControls.RJButton();
            this.BottemPanel = new System.Windows.Forms.Panel();
            this.ClearBtn = new RJCodeAdvance.RJControls.RJButton();
            this.lblBrands = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.MiddlePanel = new System.Windows.Forms.Panel();
            this.ListCars = new AdminPanel.UI.CustomListView();
            this.NameCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrandCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModelYearCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BranchCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColorCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SeatsCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsElectricCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsAutomaticCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TopPanel.SuspendLayout();
            this.BottemPanel.SuspendLayout();
            this.MiddlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.IsAutomatic);
            this.TopPanel.Controls.Add(this.SizeCombo);
            this.TopPanel.Controls.Add(this.ModelYearText);
            this.TopPanel.Controls.Add(this.PriceText);
            this.TopPanel.Controls.Add(this.SeatsText);
            this.TopPanel.Controls.Add(this.NameText);
            this.TopPanel.Controls.Add(this.PriceLbl);
            this.TopPanel.Controls.Add(this.IsElectricToggle);
            this.TopPanel.Controls.Add(this.ColorCombo);
            this.TopPanel.Controls.Add(this.BrandCombo);
            this.TopPanel.Controls.Add(this.BranchCombo);
            this.TopPanel.Controls.Add(this.EditBtn);
            this.TopPanel.Controls.Add(this.LogBtn);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1264, 94);
            this.TopPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(325, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Is Automatic : ";
            // 
            // IsAutomatic
            // 
            this.IsAutomatic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IsAutomatic.AutoSize = true;
            this.IsAutomatic.Location = new System.Drawing.Point(408, 8);
            this.IsAutomatic.MinimumSize = new System.Drawing.Size(80, 30);
            this.IsAutomatic.Name = "IsAutomatic";
            this.IsAutomatic.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.IsAutomatic.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.IsAutomatic.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.IsAutomatic.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.IsAutomatic.Size = new System.Drawing.Size(80, 30);
            this.IsAutomatic.TabIndex = 86;
            this.IsAutomatic.UseVisualStyleBackColor = true;
            this.IsAutomatic.CheckedChanged += new System.EventHandler(this.IsAutomatic_CheckedChanged);
            // 
            // SizeCombo
            // 
            this.SizeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.SizeCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.SizeCombo.BorderSize = 0;
            this.SizeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.SizeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SizeCombo.ForeColor = System.Drawing.Color.DarkGray;
            this.SizeCombo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.SizeCombo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.SizeCombo.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.SizeCombo.Location = new System.Drawing.Point(810, 52);
            this.SizeCombo.MinimumSize = new System.Drawing.Size(150, 30);
            this.SizeCombo.Name = "SizeCombo";
            this.SizeCombo.Size = new System.Drawing.Size(150, 32);
            this.SizeCombo.TabIndex = 85;
            this.SizeCombo.Texts = "Select Size";
            this.SizeCombo.OnSelectedIndexChanged += new System.EventHandler(this.SizeCombo_OnSelectedIndexChanged);
            // 
            // ModelYearText
            // 
            this.ModelYearText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelYearText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ModelYearText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ModelYearText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ModelYearText.BorderRadius = 10;
            this.ModelYearText.BorderSize = 1;
            this.ModelYearText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelYearText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ModelYearText.Location = new System.Drawing.Point(653, 8);
            this.ModelYearText.Margin = new System.Windows.Forms.Padding(4);
            this.ModelYearText.Multiline = false;
            this.ModelYearText.Name = "ModelYearText";
            this.ModelYearText.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.ModelYearText.PasswordChar = false;
            this.ModelYearText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ModelYearText.PlaceholderText = "Model Year";
            this.ModelYearText.Size = new System.Drawing.Size(150, 27);
            this.ModelYearText.TabIndex = 83;
            this.ModelYearText.Texts = "";
            this.ModelYearText.UnderlinedStyle = false;
            this.ModelYearText._TextChanged += new System.EventHandler(this.ModelYearText__TextChangedAsync);
            this.ModelYearText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModelYearText_KeyPress);
            // 
            // PriceText
            // 
            this.PriceText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PriceText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PriceText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PriceText.BorderRadius = 10;
            this.PriceText.BorderSize = 1;
            this.PriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.PriceText.Location = new System.Drawing.Point(495, 7);
            this.PriceText.Margin = new System.Windows.Forms.Padding(4);
            this.PriceText.Multiline = false;
            this.PriceText.Name = "PriceText";
            this.PriceText.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.PriceText.PasswordChar = false;
            this.PriceText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.PriceText.PlaceholderText = "Car Price";
            this.PriceText.Size = new System.Drawing.Size(150, 27);
            this.PriceText.TabIndex = 82;
            this.PriceText.Texts = "";
            this.PriceText.UnderlinedStyle = false;
            this.PriceText._TextChanged += new System.EventHandler(this.PriceText__TextChanged);
            this.PriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceText_KeyPress);
            // 
            // SeatsText
            // 
            this.SeatsText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeatsText.AutoSize = true;
            this.SeatsText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.SeatsText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.SeatsText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.SeatsText.BorderRadius = 10;
            this.SeatsText.BorderSize = 1;
            this.SeatsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.SeatsText.Location = new System.Drawing.Point(653, 57);
            this.SeatsText.Margin = new System.Windows.Forms.Padding(4);
            this.SeatsText.Multiline = false;
            this.SeatsText.Name = "SeatsText";
            this.SeatsText.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.SeatsText.PasswordChar = false;
            this.SeatsText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.SeatsText.PlaceholderText = "Car Seats";
            this.SeatsText.Size = new System.Drawing.Size(150, 27);
            this.SeatsText.TabIndex = 81;
            this.SeatsText.Texts = "";
            this.SeatsText.UnderlinedStyle = false;
            this.SeatsText._TextChanged += new System.EventHandler(this.SeatsText__TextChanged);
            this.SeatsText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SeatsText_KeyPress);
            // 
            // NameText
            // 
            this.NameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.NameText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.NameText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.NameText.BorderRadius = 10;
            this.NameText.BorderSize = 1;
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.NameText.Location = new System.Drawing.Point(495, 57);
            this.NameText.Margin = new System.Windows.Forms.Padding(4);
            this.NameText.Multiline = false;
            this.NameText.Name = "NameText";
            this.NameText.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.NameText.PasswordChar = false;
            this.NameText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.NameText.PlaceholderText = "Car Name";
            this.NameText.Size = new System.Drawing.Size(150, 27);
            this.NameText.TabIndex = 80;
            this.NameText.Texts = "";
            this.NameText.UnderlinedStyle = false;
            this.NameText._TextChanged += new System.EventHandler(this.NameText__TextChanged);
            // 
            // PriceLbl
            // 
            this.PriceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.ForeColor = System.Drawing.Color.DarkGray;
            this.PriceLbl.Location = new System.Drawing.Point(325, 52);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(90, 20);
            this.PriceLbl.TabIndex = 79;
            this.PriceLbl.Text = "Is Electric : ";
            // 
            // IsElectricToggle
            // 
            this.IsElectricToggle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IsElectricToggle.AutoSize = true;
            this.IsElectricToggle.Location = new System.Drawing.Point(408, 54);
            this.IsElectricToggle.MinimumSize = new System.Drawing.Size(80, 30);
            this.IsElectricToggle.Name = "IsElectricToggle";
            this.IsElectricToggle.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.IsElectricToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.IsElectricToggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.IsElectricToggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.IsElectricToggle.Size = new System.Drawing.Size(80, 30);
            this.IsElectricToggle.TabIndex = 78;
            this.IsElectricToggle.UseVisualStyleBackColor = true;
            this.IsElectricToggle.CheckedChanged += new System.EventHandler(this.IsElectricToggle_CheckedChanged);
            // 
            // ColorCombo
            // 
            this.ColorCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ColorCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ColorCombo.BorderSize = 0;
            this.ColorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ColorCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ColorCombo.ForeColor = System.Drawing.Color.DarkGray;
            this.ColorCombo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ColorCombo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ColorCombo.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ColorCombo.Location = new System.Drawing.Point(810, 8);
            this.ColorCombo.MinimumSize = new System.Drawing.Size(150, 30);
            this.ColorCombo.Name = "ColorCombo";
            this.ColorCombo.Size = new System.Drawing.Size(150, 32);
            this.ColorCombo.TabIndex = 76;
            this.ColorCombo.Texts = "Select Color";
            this.ColorCombo.OnSelectedIndexChanged += new System.EventHandler(this.ColorCombo_OnSelectedIndexChanged);
            // 
            // BrandCombo
            // 
            this.BrandCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrandCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BrandCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BrandCombo.BorderSize = 0;
            this.BrandCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.BrandCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BrandCombo.ForeColor = System.Drawing.Color.DarkGray;
            this.BrandCombo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.BrandCombo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BrandCombo.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.BrandCombo.Location = new System.Drawing.Point(966, 8);
            this.BrandCombo.MinimumSize = new System.Drawing.Size(150, 30);
            this.BrandCombo.Name = "BrandCombo";
            this.BrandCombo.Size = new System.Drawing.Size(150, 32);
            this.BrandCombo.TabIndex = 75;
            this.BrandCombo.Texts = "Select Brand";
            this.BrandCombo.OnSelectedIndexChanged += new System.EventHandler(this.BrandCombo_OnSelectedIndexChanged);
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
            this.BranchCombo.Location = new System.Drawing.Point(966, 52);
            this.BranchCombo.MinimumSize = new System.Drawing.Size(150, 30);
            this.BranchCombo.Name = "BranchCombo";
            this.BranchCombo.Size = new System.Drawing.Size(150, 32);
            this.BranchCombo.TabIndex = 74;
            this.BranchCombo.Texts = "Select Branch";
            this.BranchCombo.OnSelectedIndexChanged += new System.EventHandler(this.BranchCombo_OnSelectedIndexChanged);
            // 
            // EditBtn
            // 
            this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.EditBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.EditBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.EditBtn.BorderRadius = 15;
            this.EditBtn.BorderSize = 0;
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(1140, 54);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(100, 35);
            this.EditBtn.TabIndex = 73;
            this.EditBtn.Text = "Edit Car";
            this.EditBtn.TextColor = System.Drawing.Color.White;
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // LogBtn
            // 
            this.LogBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.LogBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.LogBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.LogBtn.BorderRadius = 15;
            this.LogBtn.BorderSize = 0;
            this.LogBtn.FlatAppearance.BorderSize = 0;
            this.LogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogBtn.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBtn.ForeColor = System.Drawing.Color.White;
            this.LogBtn.Location = new System.Drawing.Point(1140, 7);
            this.LogBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.Size = new System.Drawing.Size(100, 35);
            this.LogBtn.TabIndex = 72;
            this.LogBtn.Text = "Add Car";
            this.LogBtn.TextColor = System.Drawing.Color.White;
            this.LogBtn.UseVisualStyleBackColor = false;
            this.LogBtn.Click += new System.EventHandler(this.LogBtn_Click);
            // 
            // BottemPanel
            // 
            this.BottemPanel.Controls.Add(this.ClearBtn);
            this.BottemPanel.Controls.Add(this.lblBrands);
            this.BottemPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottemPanel.Location = new System.Drawing.Point(0, 739);
            this.BottemPanel.Name = "BottemPanel";
            this.BottemPanel.Size = new System.Drawing.Size(1264, 80);
            this.BottemPanel.TabIndex = 1;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ClearBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ClearBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ClearBtn.BorderRadius = 15;
            this.ClearBtn.BorderSize = 0;
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(1085, 34);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(155, 35);
            this.ClearBtn.TabIndex = 74;
            this.ClearBtn.Text = "Clear Searchs";
            this.ClearBtn.TextColor = System.Drawing.Color.White;
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // lblBrands
            // 
            this.lblBrands.AutoSize = true;
            this.lblBrands.Font = new System.Drawing.Font("Impact", 24F);
            this.lblBrands.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lblBrands.Location = new System.Drawing.Point(17, 18);
            this.lblBrands.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrands.Name = "lblBrands";
            this.lblBrands.Size = new System.Drawing.Size(112, 39);
            this.lblBrands.TabIndex = 60;
            this.lblBrands.Text = "Cars : 0";
            // 
            // LeftPanel
            // 
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 94);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(24, 645);
            this.LeftPanel.TabIndex = 0;
            // 
            // RightPanel
            // 
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(1240, 94);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(24, 645);
            this.RightPanel.TabIndex = 1;
            // 
            // MiddlePanel
            // 
            this.MiddlePanel.Controls.Add(this.ListCars);
            this.MiddlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddlePanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MiddlePanel.Location = new System.Drawing.Point(24, 94);
            this.MiddlePanel.Name = "MiddlePanel";
            this.MiddlePanel.Size = new System.Drawing.Size(1216, 645);
            this.MiddlePanel.TabIndex = 2;
            // 
            // ListCars
            // 
            this.ListCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ListCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCh,
            this.BrandCh,
            this.ModelYearCh,
            this.BranchCh,
            this.ColorCh,
            this.SizeCh,
            this.SeatsCH,
            this.IsElectricCh,
            this.IsAutomaticCh,
            this.PriceCh});
            this.ListCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListCars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ListCars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListCars.HideSelection = false;
            this.ListCars.Location = new System.Drawing.Point(0, 0);
            this.ListCars.Margin = new System.Windows.Forms.Padding(2);
            this.ListCars.Name = "ListCars";
            this.ListCars.OwnerDraw = true;
            this.ListCars.SelectionColor = System.Drawing.Color.LightBlue;
            this.ListCars.Size = new System.Drawing.Size(1216, 645);
            this.ListCars.TabIndex = 3;
            this.ListCars.UseCompatibleStateImageBehavior = false;
            this.ListCars.View = System.Windows.Forms.View.Details;
            this.ListCars.DoubleClick += new System.EventHandler(this.ListCars_DoubleClick);
            // 
            // NameCh
            // 
            this.NameCh.Text = "Name";
            this.NameCh.Width = 150;
            // 
            // BrandCh
            // 
            this.BrandCh.Text = "Brand";
            this.BrandCh.Width = 150;
            // 
            // ModelYearCh
            // 
            this.ModelYearCh.Text = "Model Year";
            this.ModelYearCh.Width = 140;
            // 
            // BranchCh
            // 
            this.BranchCh.Text = "Branch";
            this.BranchCh.Width = 250;
            // 
            // ColorCh
            // 
            this.ColorCh.Text = "Color";
            this.ColorCh.Width = 100;
            // 
            // SizeCh
            // 
            this.SizeCh.Text = "Size";
            this.SizeCh.Width = 100;
            // 
            // SeatsCH
            // 
            this.SeatsCH.Text = "Seats";
            this.SeatsCH.Width = 80;
            // 
            // IsElectricCh
            // 
            this.IsElectricCh.Text = "Is Electric";
            this.IsElectricCh.Width = 120;
            // 
            // IsAutomaticCh
            // 
            this.IsAutomaticCh.Text = "Is Automatic";
            this.IsAutomaticCh.Width = 110;
            // 
            // PriceCh
            // 
            this.PriceCh.Text = "Daily Price";
            this.PriceCh.Width = 150;
            // 
            // Frm_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1264, 819);
            this.Controls.Add(this.MiddlePanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.BottemPanel);
            this.Controls.Add(this.TopPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_List";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Frm_List_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.BottemPanel.ResumeLayout(false);
            this.BottemPanel.PerformLayout();
            this.MiddlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

		#endregion

		private Panel TopPanel;
		private Panel BottemPanel;
		private Panel LeftPanel;
		private Panel RightPanel;
		private Panel MiddlePanel;
		private RJCodeAdvance.RJControls.RJTextBox ModelYearText;
		private RJCodeAdvance.RJControls.RJTextBox PriceText;
		private RJCodeAdvance.RJControls.RJTextBox SeatsText;
		private RJCodeAdvance.RJControls.RJTextBox NameText;
		private Label PriceLbl;
		private RJCodeAdvance.RJControls.RJToggleButton IsElectricToggle;
		private RJCodeAdvance.RJControls.RJComboBox ColorCombo;
		private RJCodeAdvance.RJControls.RJComboBox BrandCombo;
		private RJCodeAdvance.RJControls.RJComboBox BranchCombo;

		private RJCodeAdvance.RJControls.RJButton EditBtn;
		private RJCodeAdvance.RJControls.RJButton LogBtn;
		private CustomListView ListCars;
		private ColumnHeader NameCh;
		private ColumnHeader BrandCh;
		private ColumnHeader ModelYearCh;
		private ColumnHeader BranchCh;
		private ColumnHeader ColorCh;
		private ColumnHeader SizeCh;
		private ColumnHeader SeatsCH;
		private ColumnHeader IsElectricCh;
		private ColumnHeader PriceCh;
		private Label lblBrands;
		private RJCodeAdvance.RJControls.RJComboBox SizeCombo;
        private RJCodeAdvance.RJControls.RJButton ClearBtn;
        private Label label1;
        private RJCodeAdvance.RJControls.RJToggleButton IsAutomatic;
        private ColumnHeader IsAutomaticCh;
    }
}