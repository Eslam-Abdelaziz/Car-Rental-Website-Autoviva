namespace AdminPanel.UI
{
    partial class CarView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CarPicBox = new System.Windows.Forms.PictureBox();
            this.NextBtn = new FontAwesome.Sharp.IconButton();
            this.BackBtn = new FontAwesome.Sharp.IconButton();
            this.NameLbl = new System.Windows.Forms.Label();
            this.BrandLbl = new System.Windows.Forms.Label();
            this.SizeLbl = new System.Windows.Forms.Label();
            this.ColorLbl = new System.Windows.Forms.Label();
            this.ModelYearLbl = new System.Windows.Forms.Label();
            this.SeatsLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.LblElectric = new System.Windows.Forms.Label();
            this.LblAutomatic = new System.Windows.Forms.Label();
            this.LblFuelUsage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CarPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CarPicBox
            // 
            this.CarPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CarPicBox.Location = new System.Drawing.Point(31, 12);
            this.CarPicBox.Name = "CarPicBox";
            this.CarPicBox.Size = new System.Drawing.Size(507, 348);
            this.CarPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CarPicBox.TabIndex = 0;
            this.CarPicBox.TabStop = false;
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NextBtn.FlatAppearance.BorderSize = 0;
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtn.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.NextBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.NextBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NextBtn.Location = new System.Drawing.Point(538, 155);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(26, 46);
            this.NextBtn.TabIndex = 1;
            this.NextBtn.TabStop = false;
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            this.BackBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.BackBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BackBtn.Location = new System.Drawing.Point(3, 155);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(26, 46);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.TabStop = false;
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.NameLbl.Location = new System.Drawing.Point(33, 386);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(116, 18);
            this.NameLbl.TabIndex = 3;
            this.NameLbl.Text = "Nissan Sunny";
            // 
            // BrandLbl
            // 
            this.BrandLbl.AutoSize = true;
            this.BrandLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.BrandLbl.Location = new System.Drawing.Point(33, 434);
            this.BrandLbl.Name = "BrandLbl";
            this.BrandLbl.Size = new System.Drawing.Size(62, 18);
            this.BrandLbl.TabIndex = 5;
            this.BrandLbl.Text = "Nissan";
            // 
            // SizeLbl
            // 
            this.SizeLbl.AutoSize = true;
            this.SizeLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.SizeLbl.Location = new System.Drawing.Point(250, 386);
            this.SizeLbl.Name = "SizeLbl";
            this.SizeLbl.Size = new System.Drawing.Size(41, 18);
            this.SizeLbl.TabIndex = 6;
            this.SizeLbl.Text = "Size";
            // 
            // ColorLbl
            // 
            this.ColorLbl.AutoSize = true;
            this.ColorLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ColorLbl.Location = new System.Drawing.Point(428, 387);
            this.ColorLbl.Name = "ColorLbl";
            this.ColorLbl.Size = new System.Drawing.Size(53, 18);
            this.ColorLbl.TabIndex = 7;
            this.ColorLbl.Text = "White";
            // 
            // ModelYearLbl
            // 
            this.ModelYearLbl.AutoSize = true;
            this.ModelYearLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelYearLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ModelYearLbl.Location = new System.Drawing.Point(123, 434);
            this.ModelYearLbl.Name = "ModelYearLbl";
            this.ModelYearLbl.Size = new System.Drawing.Size(48, 18);
            this.ModelYearLbl.TabIndex = 8;
            this.ModelYearLbl.Text = "2020";
            // 
            // SeatsLbl
            // 
            this.SeatsLbl.AutoSize = true;
            this.SeatsLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.SeatsLbl.Location = new System.Drawing.Point(250, 434);
            this.SeatsLbl.Name = "SeatsLbl";
            this.SeatsLbl.Size = new System.Drawing.Size(68, 18);
            this.SeatsLbl.TabIndex = 9;
            this.SeatsLbl.Text = "5 Seats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(406, 681);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Electric";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.PriceLbl.Location = new System.Drawing.Point(428, 477);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(96, 18);
            this.PriceLbl.TabIndex = 11;
            this.PriceLbl.Text = "85 LE / Day";
            this.PriceLbl.Click += new System.EventHandler(this.PriceLbl_Click);
            // 
            // LblElectric
            // 
            this.LblElectric.AutoSize = true;
            this.LblElectric.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblElectric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.LblElectric.Location = new System.Drawing.Point(33, 477);
            this.LblElectric.Name = "LblElectric";
            this.LblElectric.Size = new System.Drawing.Size(70, 18);
            this.LblElectric.TabIndex = 12;
            this.LblElectric.Text = "Electric";
            // 
            // LblAutomatic
            // 
            this.LblAutomatic.AutoSize = true;
            this.LblAutomatic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutomatic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.LblAutomatic.Location = new System.Drawing.Point(250, 477);
            this.LblAutomatic.Name = "LblAutomatic";
            this.LblAutomatic.Size = new System.Drawing.Size(90, 18);
            this.LblAutomatic.TabIndex = 13;
            this.LblAutomatic.Text = "Automatic";
            this.LblAutomatic.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblFuelUsage
            // 
            this.LblFuelUsage.AutoSize = true;
            this.LblFuelUsage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFuelUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.LblFuelUsage.Location = new System.Drawing.Point(428, 425);
            this.LblFuelUsage.Name = "LblFuelUsage";
            this.LblFuelUsage.Size = new System.Drawing.Size(18, 18);
            this.LblFuelUsage.TabIndex = 14;
            this.LblFuelUsage.Text = "0";
            // 
            // CarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.LblFuelUsage);
            this.Controls.Add(this.LblAutomatic);
            this.Controls.Add(this.LblElectric);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SeatsLbl);
            this.Controls.Add(this.ModelYearLbl);
            this.Controls.Add(this.ColorLbl);
            this.Controls.Add(this.SizeLbl);
            this.Controls.Add(this.BrandLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.CarPicBox);
            this.MinimumSize = new System.Drawing.Size(547, 469);
            this.Name = "CarView";
            this.Size = new System.Drawing.Size(567, 512);
            this.Load += new System.EventHandler(this.CarView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CarPicBox;
        private FontAwesome.Sharp.IconButton NextBtn;
        private FontAwesome.Sharp.IconButton BackBtn;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label BrandLbl;
        private System.Windows.Forms.Label SizeLbl;
        private System.Windows.Forms.Label ColorLbl;
        private System.Windows.Forms.Label ModelYearLbl;
        private System.Windows.Forms.Label SeatsLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label LblElectric;
        private System.Windows.Forms.Label LblAutomatic;
        private System.Windows.Forms.Label LblFuelUsage;
    }
}
