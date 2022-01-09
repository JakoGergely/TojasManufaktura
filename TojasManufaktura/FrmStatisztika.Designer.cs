namespace TojasManufaktura
{
    partial class FrmStatisztika
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
            this.mnev = new System.Windows.Forms.Label();
            this.kivHon = new System.Windows.Forms.Label();
            this.termelNaplo = new System.Windows.Forms.Label();
            this.ahttö = new System.Windows.Forms.Label();
            this.hlgytsz = new System.Windows.Forms.Label();
            this.statisztikadgv = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legtobbText = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.munkasNeve = new System.Windows.Forms.ComboBox();
            this.honapSzam = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.statisztikadgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honapSzam)).BeginInit();
            this.SuspendLayout();
            // 
            // mnev
            // 
            this.mnev.AutoSize = true;
            this.mnev.Location = new System.Drawing.Point(21, 31);
            this.mnev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mnev.Name = "mnev";
            this.mnev.Size = new System.Drawing.Size(91, 16);
            this.mnev.TabIndex = 0;
            this.mnev.Text = "Munkás neve:";
            // 
            // kivHon
            // 
            this.kivHon.AutoSize = true;
            this.kivHon.Location = new System.Drawing.Point(397, 31);
            this.kivHon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kivHon.Name = "kivHon";
            this.kivHon.Size = new System.Drawing.Size(181, 16);
            this.kivHon.TabIndex = 1;
            this.kivHon.Text = "Kiválasztott hónap sorszáma:";
            // 
            // termelNaplo
            // 
            this.termelNaplo.AutoSize = true;
            this.termelNaplo.Location = new System.Drawing.Point(21, 79);
            this.termelNaplo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.termelNaplo.Name = "termelNaplo";
            this.termelNaplo.Size = new System.Drawing.Size(109, 16);
            this.termelNaplo.TabIndex = 2;
            this.termelNaplo.Text = "Termelési napló:";
            // 
            // ahttö
            // 
            this.ahttö.AutoSize = true;
            this.ahttö.Location = new System.Drawing.Point(214, 443);
            this.ahttö.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ahttö.Name = "ahttö";
            this.ahttö.Size = new System.Drawing.Size(259, 16);
            this.ahttö.TabIndex = 3;
            this.ahttö.Text = "Adott hónapban termelt tojások összsúlya:";
            // 
            // hlgytsz
            // 
            this.hlgytsz.AutoSize = true;
            this.hlgytsz.Location = new System.Drawing.Point(214, 403);
            this.hlgytsz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hlgytsz.Name = "hlgytsz";
            this.hlgytsz.Size = new System.Drawing.Size(257, 16);
            this.hlgytsz.TabIndex = 4;
            this.hlgytsz.Text = "A hónapban legtöbbet gyártott tojás színe:";
            // 
            // statisztikadgv
            // 
            this.statisztikadgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisztikadgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.szin,
            this.menny});
            this.statisztikadgv.Location = new System.Drawing.Point(24, 108);
            this.statisztikadgv.Margin = new System.Windows.Forms.Padding(4);
            this.statisztikadgv.Name = "statisztikadgv";
            this.statisztikadgv.Size = new System.Drawing.Size(625, 266);
            this.statisztikadgv.TabIndex = 5;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "Termeles.Datum";
            this.date.HeaderText = "Dátum";
            this.date.Name = "date";
            // 
            // szin
            // 
            this.szin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.szin.DataPropertyName = "Tojas.Szin";
            this.szin.HeaderText = "Szín";
            this.szin.Name = "szin";
            // 
            // menny
            // 
            this.menny.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menny.DataPropertyName = "Termeles.Mennyiseg";
            this.menny.HeaderText = "Mennyiség";
            this.menny.Name = "menny";
            // 
            // legtobbText
            // 
            this.legtobbText.Location = new System.Drawing.Point(517, 397);
            this.legtobbText.Margin = new System.Windows.Forms.Padding(4);
            this.legtobbText.Name = "legtobbText";
            this.legtobbText.Size = new System.Drawing.Size(132, 22);
            this.legtobbText.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(517, 443);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 7;
            // 
            // munkasNeve
            // 
            this.munkasNeve.FormattingEnabled = true;
            this.munkasNeve.Location = new System.Drawing.Point(150, 28);
            this.munkasNeve.Margin = new System.Windows.Forms.Padding(4);
            this.munkasNeve.Name = "munkasNeve";
            this.munkasNeve.Size = new System.Drawing.Size(174, 24);
            this.munkasNeve.TabIndex = 8;
            this.munkasNeve.SelectedIndexChanged += new System.EventHandler(this.munkasNeve_SelectedIndexChanged);
            // 
            // honapSzam
            // 
            this.honapSzam.Location = new System.Drawing.Point(600, 29);
            this.honapSzam.Margin = new System.Windows.Forms.Padding(4);
            this.honapSzam.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.honapSzam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.honapSzam.Name = "honapSzam";
            this.honapSzam.Size = new System.Drawing.Size(49, 22);
            this.honapSzam.TabIndex = 9;
            this.honapSzam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmStatisztika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(662, 497);
            this.Controls.Add(this.honapSzam);
            this.Controls.Add(this.munkasNeve);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.legtobbText);
            this.Controls.Add(this.statisztikadgv);
            this.Controls.Add(this.hlgytsz);
            this.Controls.Add(this.ahttö);
            this.Controls.Add(this.termelNaplo);
            this.Controls.Add(this.kivHon);
            this.Controls.Add(this.mnev);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStatisztika";
            this.Text = "FrmStatisztika";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statisztikadgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honapSzam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mnev;
        private System.Windows.Forms.Label kivHon;
        private System.Windows.Forms.Label termelNaplo;
        private System.Windows.Forms.Label ahttö;
        private System.Windows.Forms.Label hlgytsz;
        private System.Windows.Forms.DataGridView statisztikadgv;
        private System.Windows.Forms.TextBox legtobbText;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox munkasNeve;
        private System.Windows.Forms.NumericUpDown honapSzam;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn szin;
        private System.Windows.Forms.DataGridViewTextBoxColumn menny;
    }
}