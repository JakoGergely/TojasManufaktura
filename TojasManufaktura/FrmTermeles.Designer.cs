namespace TojasManufaktura
{
    partial class FrmTermeles
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
            this.adatok = new System.Windows.Forms.DataGridView();
            this.Dátum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TojásSzín = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mennyisés = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Munkás = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ujBejegyzes = new System.Windows.Forms.GroupBox();
            this.tojasSzam = new System.Windows.Forms.ComboBox();
            this.munkasBox = new System.Windows.Forms.ComboBox();
            this.mennyiButton = new System.Windows.Forms.NumericUpDown();
            this.datumPicker = new System.Windows.Forms.DateTimePicker();
            this.munkas = new System.Windows.Forms.Label();
            this.mennyiseg = new System.Windows.Forms.Label();
            this.tojas = new System.Windows.Forms.Label();
            this.datum = new System.Windows.Forms.Label();
            this.felvetel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adatok)).BeginInit();
            this.ujBejegyzes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mennyiButton)).BeginInit();
            this.SuspendLayout();
            // 
            // adatok
            // 
            this.adatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dátum,
            this.TojásSzín,
            this.Mennyisés,
            this.Munkás});
            this.adatok.Location = new System.Drawing.Point(12, 12);
            this.adatok.Name = "adatok";
            this.adatok.Size = new System.Drawing.Size(577, 237);
            this.adatok.TabIndex = 0;
            // 
            // Dátum
            // 
            this.Dátum.DataPropertyName = "Termeles.Datum";
            this.Dátum.HeaderText = "Dátum";
            this.Dátum.Name = "Dátum";
            // 
            // TojásSzín
            // 
            this.TojásSzín.DataPropertyName = "Tojas.Szin";
            this.TojásSzín.HeaderText = "Tojás színe";
            this.TojásSzín.Name = "TojásSzín";
            // 
            // Mennyisés
            // 
            this.Mennyisés.DataPropertyName = "Termeles.Mennyiseg";
            this.Mennyisés.HeaderText = "Mennyiség";
            this.Mennyisés.Name = "Mennyisés";
            // 
            // Munkás
            // 
            this.Munkás.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Munkás.DataPropertyName = "Nyul.Nev";
            this.Munkás.HeaderText = "Munkás";
            this.Munkás.Name = "Munkás";
            // 
            // ujBejegyzes
            // 
            this.ujBejegyzes.BackColor = System.Drawing.Color.LightCoral;
            this.ujBejegyzes.Controls.Add(this.tojasSzam);
            this.ujBejegyzes.Controls.Add(this.munkasBox);
            this.ujBejegyzes.Controls.Add(this.mennyiButton);
            this.ujBejegyzes.Controls.Add(this.datumPicker);
            this.ujBejegyzes.Controls.Add(this.munkas);
            this.ujBejegyzes.Controls.Add(this.mennyiseg);
            this.ujBejegyzes.Controls.Add(this.tojas);
            this.ujBejegyzes.Controls.Add(this.datum);
            this.ujBejegyzes.Controls.Add(this.felvetel);
            this.ujBejegyzes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujBejegyzes.Location = new System.Drawing.Point(12, 255);
            this.ujBejegyzes.Name = "ujBejegyzes";
            this.ujBejegyzes.Size = new System.Drawing.Size(577, 173);
            this.ujBejegyzes.TabIndex = 1;
            this.ujBejegyzes.TabStop = false;
            this.ujBejegyzes.Text = "Új bejegyzés";
            // 
            // tojasSzam
            // 
            this.tojasSzam.FormattingEnabled = true;
            this.tojasSzam.Location = new System.Drawing.Point(164, 85);
            this.tojasSzam.Name = "tojasSzam";
            this.tojasSzam.Size = new System.Drawing.Size(99, 26);
            this.tojasSzam.TabIndex = 8;
            // 
            // munkasBox
            // 
            this.munkasBox.FormattingEnabled = true;
            this.munkasBox.Location = new System.Drawing.Point(371, 85);
            this.munkasBox.Name = "munkasBox";
            this.munkasBox.Size = new System.Drawing.Size(200, 26);
            this.munkasBox.TabIndex = 7;
            // 
            // mennyiButton
            // 
            this.mennyiButton.Location = new System.Drawing.Point(269, 86);
            this.mennyiButton.Name = "mennyiButton";
            this.mennyiButton.Size = new System.Drawing.Size(96, 24);
            this.mennyiButton.TabIndex = 6;
            // 
            // datumPicker
            // 
            this.datumPicker.Location = new System.Drawing.Point(10, 86);
            this.datumPicker.Name = "datumPicker";
            this.datumPicker.Size = new System.Drawing.Size(143, 24);
            this.datumPicker.TabIndex = 5;
            // 
            // munkas
            // 
            this.munkas.AutoSize = true;
            this.munkas.Location = new System.Drawing.Point(368, 55);
            this.munkas.Name = "munkas";
            this.munkas.Size = new System.Drawing.Size(61, 18);
            this.munkas.TabIndex = 4;
            this.munkas.Text = "Munkás";
            // 
            // mennyiseg
            // 
            this.mennyiseg.AutoSize = true;
            this.mennyiseg.Location = new System.Drawing.Point(266, 55);
            this.mennyiseg.Name = "mennyiseg";
            this.mennyiseg.Size = new System.Drawing.Size(83, 18);
            this.mennyiseg.TabIndex = 3;
            this.mennyiseg.Text = "Mennyiség:";
            // 
            // tojas
            // 
            this.tojas.AutoSize = true;
            this.tojas.Location = new System.Drawing.Point(161, 55);
            this.tojas.Name = "tojas";
            this.tojas.Size = new System.Drawing.Size(49, 18);
            this.tojas.TabIndex = 2;
            this.tojas.Text = "Tojás:";
            // 
            // datum
            // 
            this.datum.AutoSize = true;
            this.datum.Location = new System.Drawing.Point(7, 55);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(56, 18);
            this.datum.TabIndex = 1;
            this.datum.Text = "Dátum:";
            // 
            // felvetel
            // 
            this.felvetel.Location = new System.Drawing.Point(10, 128);
            this.felvetel.Name = "felvetel";
            this.felvetel.Size = new System.Drawing.Size(561, 39);
            this.felvetel.TabIndex = 0;
            this.felvetel.Text = "Új bejegyzés felvétele!";
            this.felvetel.UseVisualStyleBackColor = true;
            this.felvetel.Click += new System.EventHandler(this.felvetel_Click);
            // 
            // FrmTermeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(605, 433);
            this.Controls.Add(this.ujBejegyzes);
            this.Controls.Add(this.adatok);
            this.Name = "FrmTermeles";
            this.Text = "FrmTermeles";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adatok)).EndInit();
            this.ujBejegyzes.ResumeLayout(false);
            this.ujBejegyzes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mennyiButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView adatok;
        private System.Windows.Forms.GroupBox ujBejegyzes;
        private System.Windows.Forms.NumericUpDown mennyiButton;
        private System.Windows.Forms.DateTimePicker datumPicker;
        private System.Windows.Forms.Label munkas;
        private System.Windows.Forms.Label mennyiseg;
        private System.Windows.Forms.Label tojas;
        private System.Windows.Forms.Label datum;
        private System.Windows.Forms.Button felvetel;
        private System.Windows.Forms.ComboBox tojasSzam;
        private System.Windows.Forms.ComboBox munkasBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dátum;
        private System.Windows.Forms.DataGridViewTextBoxColumn TojásSzín;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mennyisés;
        private System.Windows.Forms.DataGridViewTextBoxColumn Munkás;
    }
}