namespace Car
{
    partial class Car
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
            this.Start = new System.Windows.Forms.Button();
            this.BMW = new System.Windows.Forms.Label();
            this.Lexus = new System.Windows.Forms.Label();
            this.Toyota = new System.Windows.Forms.Label();
            this.Melcedes = new System.Windows.Forms.Label();
            this.ToyotaPicture = new System.Windows.Forms.PictureBox();
            this.LexusPicture = new System.Windows.Forms.PictureBox();
            this.BMWPicture = new System.Windows.Forms.PictureBox();
            this.MelcedesPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ToyotaPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LexusPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMWPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MelcedesPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(699, 55);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 73);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start!";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // BMW
            // 
            this.BMW.AutoSize = true;
            this.BMW.Location = new System.Drawing.Point(237, 24);
            this.BMW.Name = "BMW";
            this.BMW.Size = new System.Drawing.Size(39, 15);
            this.BMW.TabIndex = 6;
            this.BMW.Text = "BMW";
            // 
            // Lexus
            // 
            this.Lexus.AutoSize = true;
            this.Lexus.Location = new System.Drawing.Point(407, 24);
            this.Lexus.Name = "Lexus";
            this.Lexus.Size = new System.Drawing.Size(45, 15);
            this.Lexus.TabIndex = 7;
            this.Lexus.Text = "Lexus";
            // 
            // Toyota
            // 
            this.Toyota.AutoSize = true;
            this.Toyota.Location = new System.Drawing.Point(563, 24);
            this.Toyota.Name = "Toyota";
            this.Toyota.Size = new System.Drawing.Size(51, 15);
            this.Toyota.TabIndex = 8;
            this.Toyota.Text = "Toyota";
            // 
            // Melcedes
            // 
            this.Melcedes.AutoSize = true;
            this.Melcedes.Location = new System.Drawing.Point(51, 24);
            this.Melcedes.Name = "Melcedes";
            this.Melcedes.Size = new System.Drawing.Size(69, 15);
            this.Melcedes.TabIndex = 5;
            this.Melcedes.Text = "Mercedes";
            // 
            // ToyotaPicture
            // 
            this.ToyotaPicture.Image = global::Car.Properties.Resources.Toyota;
            this.ToyotaPicture.Location = new System.Drawing.Point(541, 55);
            this.ToyotaPicture.Name = "ToyotaPicture";
            this.ToyotaPicture.Size = new System.Drawing.Size(100, 50);
            this.ToyotaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ToyotaPicture.TabIndex = 3;
            this.ToyotaPicture.TabStop = false;
            // 
            // LexusPicture
            // 
            this.LexusPicture.Image = global::Car.Properties.Resources.Lexus;
            this.LexusPicture.Location = new System.Drawing.Point(376, 55);
            this.LexusPicture.Name = "LexusPicture";
            this.LexusPicture.Size = new System.Drawing.Size(100, 50);
            this.LexusPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LexusPicture.TabIndex = 2;
            this.LexusPicture.TabStop = false;
            // 
            // BMWPicture
            // 
            this.BMWPicture.Image = global::Car.Properties.Resources.BMW;
            this.BMWPicture.Location = new System.Drawing.Point(203, 55);
            this.BMWPicture.Name = "BMWPicture";
            this.BMWPicture.Size = new System.Drawing.Size(100, 50);
            this.BMWPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BMWPicture.TabIndex = 1;
            this.BMWPicture.TabStop = false;
            // 
            // MelcedesPicture
            // 
            this.MelcedesPicture.Image = global::Car.Properties.Resources.Melcedes;
            this.MelcedesPicture.Location = new System.Drawing.Point(35, 55);
            this.MelcedesPicture.Name = "MelcedesPicture";
            this.MelcedesPicture.Size = new System.Drawing.Size(100, 50);
            this.MelcedesPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MelcedesPicture.TabIndex = 0;
            this.MelcedesPicture.TabStop = false;
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Toyota);
            this.Controls.Add(this.Lexus);
            this.Controls.Add(this.BMW);
            this.Controls.Add(this.Melcedes);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.ToyotaPicture);
            this.Controls.Add(this.LexusPicture);
            this.Controls.Add(this.BMWPicture);
            this.Controls.Add(this.MelcedesPicture);
            this.Name = "Car";
            this.Text = "Car racing";
            this.Load += new System.EventHandler(this.Car_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToyotaPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LexusPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMWPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MelcedesPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MelcedesPicture;
        private System.Windows.Forms.PictureBox BMWPicture;
        private System.Windows.Forms.PictureBox LexusPicture;
        private System.Windows.Forms.PictureBox ToyotaPicture;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label BMW;
        private System.Windows.Forms.Label Lexus;
        private System.Windows.Forms.Label Toyota;
        private System.Windows.Forms.Label Melcedes;
    }
}

