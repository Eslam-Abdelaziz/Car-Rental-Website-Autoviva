using AdminPanel.UI;
using System.Windows.Forms;

namespace AdminPanel.Forms.Color

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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditBtn = new RJCodeAdvance.RJControls.RJButton();
            this.lblBrands = new System.Windows.Forms.Label();
            this.LogBtn = new RJCodeAdvance.RJControls.RJButton();
            this.ListColors = new AdminPanel.UI.CustomListView();
            this.NameCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(44, 528);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(841, 90);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(44, 528);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(44, 587);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(797, 31);
            this.panel5.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ListColors);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(44, 90);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 497);
            this.panel3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.lblBrands);
            this.panel1.Controls.Add(this.LogBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 90);
            this.panel1.TabIndex = 1;
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
            this.EditBtn.Location = new System.Drawing.Point(675, 32);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(165, 40);
            this.EditBtn.TabIndex = 16;
            this.EditBtn.Text = "Edit Color";
            this.EditBtn.TextColor = System.Drawing.Color.White;
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // lblBrands
            // 
            this.lblBrands.AutoSize = true;
            this.lblBrands.Font = new System.Drawing.Font("Impact", 24F);
            this.lblBrands.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lblBrands.Location = new System.Drawing.Point(44, 32);
            this.lblBrands.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrands.Name = "lblBrands";
            this.lblBrands.Size = new System.Drawing.Size(207, 60);
            this.lblBrands.TabIndex = 15;
            this.lblBrands.Text = "Colors : 0";
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
            this.LogBtn.Location = new System.Drawing.Point(502, 32);
            this.LogBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.Size = new System.Drawing.Size(165, 40);
            this.LogBtn.TabIndex = 14;
            this.LogBtn.Text = "Add Color";
            this.LogBtn.TextColor = System.Drawing.Color.White;
            this.LogBtn.UseVisualStyleBackColor = false;
            this.LogBtn.Click += new System.EventHandler(this.LogBtn_Click);
            // 
            // ListColors
            // 
            this.ListColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ListColors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListColors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCh});
            this.ListColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListColors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ListColors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListColors.HideSelection = false;
            this.ListColors.Location = new System.Drawing.Point(0, 0);
            this.ListColors.Margin = new System.Windows.Forms.Padding(2);
            this.ListColors.Name = "ListColors";
            this.ListColors.OwnerDraw = true;
            this.ListColors.SelectionColor = System.Drawing.Color.LightBlue;
            this.ListColors.Size = new System.Drawing.Size(797, 497);
            this.ListColors.TabIndex = 0;
            this.ListColors.UseCompatibleStateImageBehavior = false;
            this.ListColors.View = System.Windows.Forms.View.Details;
            // 
            // NameCh
            // 
            this.NameCh.Text = "Name";
            this.NameCh.Width = 400;
            // 
            // Frm_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(885, 618);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_List";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Frm_List_Load);
            this.panel3.ResumeLayout(false);
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
        private RJCodeAdvance.RJControls.RJButton LogBtn;
        private System.Windows.Forms.Label lblBrands;
        private RJCodeAdvance.RJControls.RJButton EditBtn;
        private CustomListView ListColors;
        private ColumnHeader NameCh;
    }
}