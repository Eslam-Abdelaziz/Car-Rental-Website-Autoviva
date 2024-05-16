using AdminPanel.UI;

namespace AdminPanel.Forms.User
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
            this.ListUsers = new AdminPanel.UI.CustomListView();
            this.EmailCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstNameCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastNameCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddressCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UsrContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addBranchControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBranchControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lable1 = new System.Windows.Forms.Label();
            this.IsBranchAdminToggle = new RJCodeAdvance.RJControls.RJToggleButton();
            this.PhoneText = new RJCodeAdvance.RJControls.RJTextBox();
            this.CityText = new RJCodeAdvance.RJControls.RJTextBox();
            this.StreetText = new RJCodeAdvance.RJControls.RJTextBox();
            this.LastText = new RJCodeAdvance.RJControls.RJTextBox();
            this.FirstText = new RJCodeAdvance.RJControls.RJTextBox();
            this.EmailSrcText = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UsrContextMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListUsers
            // 
            this.ListUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ListUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmailCH,
            this.FirstNameCH,
            this.LastNameCH,
            this.AddressCH,
            this.PhoneCh});
            this.ListUsers.ContextMenuStrip = this.UsrContextMenu;
            this.ListUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ListUsers.FullRowSelect = true;
            this.ListUsers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListUsers.HideSelection = false;
            this.ListUsers.Location = new System.Drawing.Point(0, 0);
            this.ListUsers.MultiSelect = false;
            this.ListUsers.Name = "ListUsers";
            this.ListUsers.OwnerDraw = true;
            this.ListUsers.SelectionColor = System.Drawing.Color.LightBlue;
            this.ListUsers.Size = new System.Drawing.Size(1758, 772);
            this.ListUsers.TabIndex = 0;
            this.ListUsers.UseCompatibleStateImageBehavior = false;
            this.ListUsers.View = System.Windows.Forms.View.Details;
            // 
            // EmailCH
            // 
            this.EmailCH.Text = "Email";
            this.EmailCH.Width = 300;
            // 
            // FirstNameCH
            // 
            this.FirstNameCH.Text = "First Name";
            this.FirstNameCH.Width = 150;
            // 
            // LastNameCH
            // 
            this.LastNameCH.Text = "Last Name";
            this.LastNameCH.Width = 142;
            // 
            // AddressCH
            // 
            this.AddressCH.Text = "Address";
            this.AddressCH.Width = 300;
            // 
            // PhoneCh
            // 
            this.PhoneCh.Text = "Phone";
            this.PhoneCh.Width = 200;
            // 
            // UsrContextMenu
            // 
            this.UsrContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBranchControlToolStripMenuItem,
            this.deleteBranchControlToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.UsrContextMenu.Name = "UsrContextMenu";
            this.UsrContextMenu.Size = new System.Drawing.Size(191, 70);
            // 
            // addBranchControlToolStripMenuItem
            // 
            this.addBranchControlToolStripMenuItem.Name = "addBranchControlToolStripMenuItem";
            this.addBranchControlToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.addBranchControlToolStripMenuItem.Text = "Add Branch Control";
            this.addBranchControlToolStripMenuItem.Click += new System.EventHandler(this.addBranchControlToolStripMenuItem_Click);
            // 
            // deleteBranchControlToolStripMenuItem
            // 
            this.deleteBranchControlToolStripMenuItem.Name = "deleteBranchControlToolStripMenuItem";
            this.deleteBranchControlToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.deleteBranchControlToolStripMenuItem.Text = "Delete Branch Control";
            this.deleteBranchControlToolStripMenuItem.Click += new System.EventHandler(this.deleteBranchControlToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete user";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lable1);
            this.panel1.Controls.Add(this.IsBranchAdminToggle);
            this.panel1.Controls.Add(this.PhoneText);
            this.panel1.Controls.Add(this.CityText);
            this.panel1.Controls.Add(this.StreetText);
            this.panel1.Controls.Add(this.LastText);
            this.panel1.Controls.Add(this.FirstText);
            this.panel1.Controls.Add(this.EmailSrcText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1890, 138);
            this.panel1.TabIndex = 1;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.DarkGray;
            this.lable1.Location = new System.Drawing.Point(94, 22);
            this.lable1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(121, 20);
            this.lable1.TabIndex = 30;
            this.lable1.Text = "Branch Admin : ";
            // 
            // IsBranchAdminToggle
            // 
            this.IsBranchAdminToggle.AutoSize = true;
            this.IsBranchAdminToggle.Location = new System.Drawing.Point(285, 12);
            this.IsBranchAdminToggle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IsBranchAdminToggle.MinimumSize = new System.Drawing.Size(120, 46);
            this.IsBranchAdminToggle.Name = "IsBranchAdminToggle";
            this.IsBranchAdminToggle.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.IsBranchAdminToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.IsBranchAdminToggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.IsBranchAdminToggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.IsBranchAdminToggle.Size = new System.Drawing.Size(120, 46);
            this.IsBranchAdminToggle.TabIndex = 29;
            this.IsBranchAdminToggle.UseVisualStyleBackColor = true;
            this.IsBranchAdminToggle.CheckedChanged += new System.EventHandler(this.IsBranchAdminToggle_CheckedChanged);
            // 
            // PhoneText
            // 
            this.PhoneText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PhoneText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PhoneText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PhoneText.BorderRadius = 10;
            this.PhoneText.BorderSize = 1;
            this.PhoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.PhoneText.Location = new System.Drawing.Point(1576, 71);
            this.PhoneText.Margin = new System.Windows.Forms.Padding(6);
            this.PhoneText.Multiline = false;
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.PhoneText.PasswordChar = false;
            this.PhoneText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.PhoneText.PlaceholderText = "Search Phone";
            this.PhoneText.Size = new System.Drawing.Size(248, 33);
            this.PhoneText.TabIndex = 12;
            this.PhoneText.Texts = "";
            this.PhoneText.UnderlinedStyle = false;
            this.PhoneText._TextChanged += new System.EventHandler(this.PhoneText__TextChanged);
            // 
            // CityText
            // 
            this.CityText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CityText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.CityText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.CityText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.CityText.BorderRadius = 10;
            this.CityText.BorderSize = 1;
            this.CityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.CityText.Location = new System.Drawing.Point(992, 71);
            this.CityText.Margin = new System.Windows.Forms.Padding(6);
            this.CityText.Multiline = false;
            this.CityText.Name = "CityText";
            this.CityText.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.CityText.PasswordChar = false;
            this.CityText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CityText.PlaceholderText = "Search City";
            this.CityText.Size = new System.Drawing.Size(248, 33);
            this.CityText.TabIndex = 11;
            this.CityText.Texts = "";
            this.CityText.UnderlinedStyle = false;
            this.CityText._TextChanged += new System.EventHandler(this.CityText__TextChanged);
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
            this.StreetText.Location = new System.Drawing.Point(435, 71);
            this.StreetText.Margin = new System.Windows.Forms.Padding(6);
            this.StreetText.Multiline = false;
            this.StreetText.Name = "StreetText";
            this.StreetText.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.StreetText.PasswordChar = false;
            this.StreetText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.StreetText.PlaceholderText = "Search Street";
            this.StreetText.Size = new System.Drawing.Size(248, 33);
            this.StreetText.TabIndex = 10;
            this.StreetText.Texts = "";
            this.StreetText.UnderlinedStyle = false;
            this.StreetText._TextChanged += new System.EventHandler(this.StreetText__TextChanged);
            // 
            // LastText
            // 
            this.LastText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.LastText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.LastText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.LastText.BorderRadius = 10;
            this.LastText.BorderSize = 1;
            this.LastText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.LastText.Location = new System.Drawing.Point(1576, 12);
            this.LastText.Margin = new System.Windows.Forms.Padding(6);
            this.LastText.Multiline = false;
            this.LastText.Name = "LastText";
            this.LastText.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.LastText.PasswordChar = false;
            this.LastText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.LastText.PlaceholderText = "Search Last Name";
            this.LastText.Size = new System.Drawing.Size(248, 33);
            this.LastText.TabIndex = 9;
            this.LastText.Texts = "";
            this.LastText.UnderlinedStyle = false;
            this.LastText._TextChanged += new System.EventHandler(this.LastText__TextChanged);
            // 
            // FirstText
            // 
            this.FirstText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FirstText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.FirstText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.FirstText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.FirstText.BorderRadius = 10;
            this.FirstText.BorderSize = 1;
            this.FirstText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.FirstText.Location = new System.Drawing.Point(992, 11);
            this.FirstText.Margin = new System.Windows.Forms.Padding(6);
            this.FirstText.Multiline = false;
            this.FirstText.Name = "FirstText";
            this.FirstText.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.FirstText.PasswordChar = false;
            this.FirstText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.FirstText.PlaceholderText = "Search First Name";
            this.FirstText.Size = new System.Drawing.Size(248, 33);
            this.FirstText.TabIndex = 8;
            this.FirstText.Texts = "";
            this.FirstText.UnderlinedStyle = false;
            this.FirstText._TextChanged += new System.EventHandler(this.FirstText__TextChanged);
            // 
            // EmailSrcText
            // 
            this.EmailSrcText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.EmailSrcText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.EmailSrcText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.EmailSrcText.BorderRadius = 10;
            this.EmailSrcText.BorderSize = 1;
            this.EmailSrcText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailSrcText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.EmailSrcText.Location = new System.Drawing.Point(435, 17);
            this.EmailSrcText.Margin = new System.Windows.Forms.Padding(6);
            this.EmailSrcText.Multiline = false;
            this.EmailSrcText.Name = "EmailSrcText";
            this.EmailSrcText.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.EmailSrcText.PasswordChar = false;
            this.EmailSrcText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.EmailSrcText.PlaceholderText = "Search Email";
            this.EmailSrcText.Size = new System.Drawing.Size(248, 33);
            this.EmailSrcText.TabIndex = 7;
            this.EmailSrcText.Texts = "";
            this.EmailSrcText.UnderlinedStyle = false;
            this.EmailSrcText._TextChanged += new System.EventHandler(this.EmailSrcText__TextChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(66, 820);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1824, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(66, 820);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(66, 910);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1758, 48);
            this.panel5.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ListUsers);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(66, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1758, 772);
            this.panel3.TabIndex = 6;
            // 
            // Frm_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1890, 958);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Frm_List";
            this.ShowIcon = false;
            this.UsrContextMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomListView ListUsers;
        private System.Windows.Forms.ColumnHeader EmailCH;
        private System.Windows.Forms.ColumnHeader FirstNameCH;
        private System.Windows.Forms.ColumnHeader LastNameCH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ColumnHeader AddressCH;
        private RJCodeAdvance.RJControls.RJTextBox EmailSrcText;
        private RJCodeAdvance.RJControls.RJTextBox LastText;
        private RJCodeAdvance.RJControls.RJTextBox FirstText;
        private RJCodeAdvance.RJControls.RJTextBox PhoneText;
        private RJCodeAdvance.RJControls.RJTextBox CityText;
        private RJCodeAdvance.RJControls.RJTextBox StreetText;
        private System.Windows.Forms.ColumnHeader PhoneCh;
		private System.Windows.Forms.ContextMenuStrip UsrContextMenu;
		private System.Windows.Forms.ToolStripMenuItem addBranchControlToolStripMenuItem;
        private System.Windows.Forms.Label lable1;
        private RJCodeAdvance.RJControls.RJToggleButton IsBranchAdminToggle;
        private System.Windows.Forms.ToolStripMenuItem deleteBranchControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
    }
}