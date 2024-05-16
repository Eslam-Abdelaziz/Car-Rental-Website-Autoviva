namespace AdminPanel.Forms.Car
{
    partial class Frm_View
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
            this.CarView = new AdminPanel.UI.CarView();
            this.SuspendLayout();
            // 
            // CarView
            // 
            this.CarView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.CarView.Location = new System.Drawing.Point(2, 12);
            this.CarView.MinimumSize = new System.Drawing.Size(547, 469);
            this.CarView.Name = "CarView";
            this.CarView.Size = new System.Drawing.Size(575, 537);
            this.CarView.TabIndex = 22;
            // 
            // Frm_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(580, 551);
            this.Controls.Add(this.CarView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_View";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Car";
            this.Load += new System.EventHandler(this.Frm_Add_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private UI.CarView CarView;
    }
}