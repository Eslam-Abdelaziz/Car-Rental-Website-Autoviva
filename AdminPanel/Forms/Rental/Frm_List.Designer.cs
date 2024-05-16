using AdminPanel.UI;
using System.Windows.Forms;

namespace AdminPanel.Forms.Rental

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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblRentals = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ListRentals = new AdminPanel.UI.CustomListView();
            this.UserNameCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaymentCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RentDateCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReturnDateCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReturnBranchCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPriceCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RentalCombo = new RJCodeAdvance.RJControls.RJComboBox();
            this.LblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.PriceText = new RJCodeAdvance.RJControls.RJTextBox();
            this.ToDatePicker = new RJCodeAdvance.RJControls.RJDatePicker();
            this.EmailText = new RJCodeAdvance.RJControls.RJTextBox();
            this.FromDatePicker = new RJCodeAdvance.RJControls.RJDatePicker();
            this.NameText = new RJCodeAdvance.RJControls.RJTextBox();
            this.PaymentTypeCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(66, 932);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1618, 140);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(66, 932);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblRentals);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(66, 989);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1552, 83);
            this.panel5.TabIndex = 5;
            // 
            // lblRentals
            // 
            this.lblRentals.AutoSize = true;
            this.lblRentals.Font = new System.Drawing.Font("Impact", 24F);
            this.lblRentals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lblRentals.Location = new System.Drawing.Point(3, 9);
            this.lblRentals.Name = "lblRentals";
            this.lblRentals.Size = new System.Drawing.Size(222, 39);
            this.lblRentals.TabIndex = 16;
            this.lblRentals.Text = "Total Rentals : 0";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ListRentals);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(66, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1552, 849);
            this.panel3.TabIndex = 6;
            // 
            // ListRentals
            // 
            this.ListRentals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ListRentals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListRentals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserNameCh,
            this.PaymentCh,
            this.RentDateCh,
            this.ReturnDateCh,
            this.StatusCh,
            this.PaymentTypeCh,
            this.ReturnBranchCh,
            this.TotalPriceCh});
            this.ListRentals.ContextMenuStrip = this.contextMenuStrip1;
            this.ListRentals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListRentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListRentals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ListRentals.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListRentals.HideSelection = false;
            this.ListRentals.Location = new System.Drawing.Point(0, 0);
            this.ListRentals.Name = "ListRentals";
            this.ListRentals.OwnerDraw = true;
            this.ListRentals.SelectionColor = System.Drawing.Color.LightBlue;
            this.ListRentals.Size = new System.Drawing.Size(1552, 849);
            this.ListRentals.TabIndex = 0;
            this.ListRentals.UseCompatibleStateImageBehavior = false;
            this.ListRentals.View = System.Windows.Forms.View.Details;
            this.ListRentals.SelectedIndexChanged += new System.EventHandler(this.ListRentals_SelectedIndexChanged);
            // 
            // UserNameCh
            // 
            this.UserNameCh.Text = "User Name";
            this.UserNameCh.Width = 150;
            // 
            // PaymentCh
            // 
            this.PaymentCh.Text = "Car";
            this.PaymentCh.Width = 150;
            // 
            // RentDateCh
            // 
            this.RentDateCh.Text = "Rent Date";
            this.RentDateCh.Width = 150;
            // 
            // ReturnDateCh
            // 
            this.ReturnDateCh.Text = "Return Date";
            this.ReturnDateCh.Width = 150;
            // 
            // StatusCh
            // 
            this.StatusCh.Text = "Status";
            this.StatusCh.Width = 100;
            // 
            // ReturnBranchCh
            // 
            this.ReturnBranchCh.Text = "Return Branch";
            this.ReturnBranchCh.Width = 150;
            // 
            // TotalPriceCh
            // 
            this.TotalPriceCh.Text = "Total Price";
            this.TotalPriceCh.Width = 120;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.viewCarToolStripMenuItem,
            this.viewUserToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 70);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // viewCarToolStripMenuItem
            // 
            this.viewCarToolStripMenuItem.Name = "viewCarToolStripMenuItem";
            this.viewCarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.viewCarToolStripMenuItem.Text = "View Car";
            this.viewCarToolStripMenuItem.Click += new System.EventHandler(this.viewCarToolStripMenuItem_Click);
            // 
            // viewUserToolStripMenuItem
            // 
            this.viewUserToolStripMenuItem.Name = "viewUserToolStripMenuItem";
            this.viewUserToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.viewUserToolStripMenuItem.Text = "View User";
            this.viewUserToolStripMenuItem.Click += new System.EventHandler(this.viewUserToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RentalCombo);
            this.panel1.Controls.Add(this.LblTo);
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Controls.Add(this.PriceText);
            this.panel1.Controls.Add(this.ToDatePicker);
            this.panel1.Controls.Add(this.EmailText);
            this.panel1.Controls.Add(this.FromDatePicker);
            this.panel1.Controls.Add(this.NameText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1684, 140);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RentalCombo
            // 
            this.RentalCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RentalCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.RentalCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.RentalCombo.BorderSize = 0;
            this.RentalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.RentalCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RentalCombo.ForeColor = System.Drawing.Color.DarkGray;
            this.RentalCombo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.RentalCombo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.RentalCombo.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.RentalCombo.Location = new System.Drawing.Point(686, 72);
            this.RentalCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RentalCombo.MinimumSize = new System.Drawing.Size(225, 46);
            this.RentalCombo.Name = "RentalCombo";
            this.RentalCombo.Size = new System.Drawing.Size(225, 49);
            this.RentalCombo.TabIndex = 94;
            this.RentalCombo.Texts = "Rental Status";
            this.RentalCombo.OnSelectedIndexChanged += new System.EventHandler(this.RentalCombo_OnSelectedIndexChanged);
            // 
            // LblTo
            // 
            this.LblTo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.LblTo.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.LblTo.Location = new System.Drawing.Point(1304, 23);
            this.LblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTo.Name = "LblTo";
            this.LblTo.Size = new System.Drawing.Size(116, 35);
            this.LblTo.TabIndex = 93;
            this.LblTo.Text = "To Date : ";
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblFrom.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lblFrom.Location = new System.Drawing.Point(940, 23);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(150, 35);
            this.lblFrom.TabIndex = 90;
            this.lblFrom.Text = "From Date : ";
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
            this.PriceText.Location = new System.Drawing.Point(468, 26);
            this.PriceText.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PriceText.Multiline = false;
            this.PriceText.Name = "PriceText";
            this.PriceText.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.PriceText.PasswordChar = false;
            this.PriceText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.PriceText.PlaceholderText = "Rental Price";
            this.PriceText.Size = new System.Drawing.Size(186, 33);
            this.PriceText.TabIndex = 86;
            this.PriceText.Texts = "";
            this.PriceText.UnderlinedStyle = false;
            this.PriceText._TextChanged += new System.EventHandler(this.PriceText__TextChanged);
            this.PriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceText_KeyPress);
            // 
            // ToDatePicker
            // 
            this.ToDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ToDatePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ToDatePicker.BorderSize = 0;
            this.ToDatePicker.Font = new System.Drawing.Font("Impact", 12F);
            this.ToDatePicker.Location = new System.Drawing.Point(1310, 68);
            this.ToDatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToDatePicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.ToDatePicker.Name = "ToDatePicker";
            this.ToDatePicker.Size = new System.Drawing.Size(307, 35);
            this.ToDatePicker.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ToDatePicker.TabIndex = 92;
            this.ToDatePicker.TextColor = System.Drawing.Color.White;
            this.ToDatePicker.ValueChanged += new System.EventHandler(this.ToDatePicker_ValueChanged);
            // 
            // EmailText
            // 
            this.EmailText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailText.AutoSize = true;
            this.EmailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.EmailText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.EmailText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.EmailText.BorderRadius = 10;
            this.EmailText.BorderSize = 1;
            this.EmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.EmailText.Location = new System.Drawing.Point(468, 80);
            this.EmailText.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EmailText.Multiline = false;
            this.EmailText.Name = "EmailText";
            this.EmailText.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.EmailText.PasswordChar = false;
            this.EmailText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.EmailText.PlaceholderText = "User Email";
            this.EmailText.Size = new System.Drawing.Size(186, 33);
            this.EmailText.TabIndex = 85;
            this.EmailText.Texts = "";
            this.EmailText.UnderlinedStyle = false;
            this.EmailText._TextChanged += new System.EventHandler(this.EmailText__TextChanged);
            // 
            // FromDatePicker
            // 
            this.FromDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FromDatePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.FromDatePicker.BorderSize = 0;
            this.FromDatePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.FromDatePicker.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDatePicker.Location = new System.Drawing.Point(945, 68);
            this.FromDatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FromDatePicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.FromDatePicker.Name = "FromDatePicker";
            this.FromDatePicker.Size = new System.Drawing.Size(318, 35);
            this.FromDatePicker.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.FromDatePicker.TabIndex = 91;
            this.FromDatePicker.TextColor = System.Drawing.Color.White;
            this.FromDatePicker.ValueChanged += new System.EventHandler(this.FromDatePicker_ValueChanged);
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
            this.NameText.Location = new System.Drawing.Point(686, 20);
            this.NameText.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NameText.Multiline = false;
            this.NameText.Name = "NameText";
            this.NameText.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.NameText.PasswordChar = false;
            this.NameText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.NameText.PlaceholderText = "User Name";
            this.NameText.Size = new System.Drawing.Size(225, 33);
            this.NameText.TabIndex = 84;
            this.NameText.Texts = "";
            this.NameText.UnderlinedStyle = false;
            this.NameText._TextChanged += new System.EventHandler(this.NameText__TextChanged);
            // 
            // PaymentTypeCh
            // 
            this.PaymentTypeCh.Text = "Payment Type";
            this.PaymentTypeCh.Width = 120;
            // 
            // Frm_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1684, 1072);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Frm_List";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Frm_List_Load);
            this.SizeChanged += new System.EventHandler(this.Frm_List_SizeChanged);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private CustomListView ListRentals;
        private ColumnHeader UserNameCh;
		private ColumnHeader PaymentCh;
        private ColumnHeader RentDateCh;
        private ColumnHeader ReturnDateCh;
        private ColumnHeader StatusCh;
        private ColumnHeader ReturnBranchCh;
        private ColumnHeader TotalPriceCh;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private RJCodeAdvance.RJControls.RJTextBox PriceText;
        private RJCodeAdvance.RJControls.RJTextBox EmailText;
        private RJCodeAdvance.RJControls.RJTextBox NameText;
        private Label LblTo;
        private Label lblFrom;
        private RJCodeAdvance.RJControls.RJDatePicker ToDatePicker;
        private RJCodeAdvance.RJControls.RJDatePicker FromDatePicker;
        private RJCodeAdvance.RJControls.RJComboBox RentalCombo;
        private Label lblRentals;
        private ToolStripMenuItem viewCarToolStripMenuItem;
        private ToolStripMenuItem viewUserToolStripMenuItem;
        private ColumnHeader PaymentTypeCh;
    }
}