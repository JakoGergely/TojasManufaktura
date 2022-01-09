namespace TojasManufaktura
{
    partial class FrmMain
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
            this.termeles = new System.Windows.Forms.Button();
            this.statisztika = new System.Windows.Forms.Button();
            this.kimutatás = new System.Windows.Forms.Button();
            this.kilepes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // termeles
            // 
            this.termeles.BackColor = System.Drawing.Color.Gainsboro;
            this.termeles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.termeles.Location = new System.Drawing.Point(12, 12);
            this.termeles.Name = "termeles";
            this.termeles.Size = new System.Drawing.Size(318, 52);
            this.termeles.TabIndex = 0;
            this.termeles.Text = "Termelés";
            this.termeles.UseVisualStyleBackColor = false;
            this.termeles.Click += new System.EventHandler(this.termeles_Click);
            // 
            // statisztika
            // 
            this.statisztika.BackColor = System.Drawing.Color.Gainsboro;
            this.statisztika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statisztika.Location = new System.Drawing.Point(12, 70);
            this.statisztika.Name = "statisztika";
            this.statisztika.Size = new System.Drawing.Size(318, 52);
            this.statisztika.TabIndex = 1;
            this.statisztika.Text = "Statisztika";
            this.statisztika.UseVisualStyleBackColor = false;
            this.statisztika.Click += new System.EventHandler(this.statisztika_Click);
            // 
            // kimutatás
            // 
            this.kimutatás.BackColor = System.Drawing.Color.Gainsboro;
            this.kimutatás.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kimutatás.Location = new System.Drawing.Point(12, 128);
            this.kimutatás.Name = "kimutatás";
            this.kimutatás.Size = new System.Drawing.Size(318, 52);
            this.kimutatás.TabIndex = 2;
            this.kimutatás.Text = "Kimutatás";
            this.kimutatás.UseVisualStyleBackColor = false;
            // 
            // kilepes
            // 
            this.kilepes.BackColor = System.Drawing.Color.Gainsboro;
            this.kilepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kilepes.Location = new System.Drawing.Point(12, 185);
            this.kilepes.Name = "kilepes";
            this.kilepes.Size = new System.Drawing.Size(318, 52);
            this.kilepes.TabIndex = 3;
            this.kilepes.Text = "Kilépés";
            this.kilepes.UseVisualStyleBackColor = false;
            this.kilepes.Click += new System.EventHandler(this.kilepes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TojasManufaktura.Properties.Resources.nyul;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = global::TojasManufaktura.Properties.Resources.nyul;
            this.pictureBox1.InitialImage = global::TojasManufaktura.Properties.Resources.nyul;
            this.pictureBox1.Location = new System.Drawing.Point(349, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 225);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(615, 256);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kilepes);
            this.Controls.Add(this.kimutatás);
            this.Controls.Add(this.statisztika);
            this.Controls.Add(this.termeles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button termeles;
        private System.Windows.Forms.Button statisztika;
        private System.Windows.Forms.Button kimutatás;
        private System.Windows.Forms.Button kilepes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

