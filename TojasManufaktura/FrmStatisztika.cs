using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TojasManufaktura
{
    public partial class FrmStatisztika : Form
    {
        public string ConnectionString { get; private set; }
        public FrmStatisztika(string connectionString)
        {
            this.ConnectionString = connectionString;
            ConnectionString =
                @"Server = (localdb)\MSSQLLocalDB;" +
                "Database = TojasGyar";
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        => Filladatok();
        private void Filladatok()
        {
            statisztikadgv.Rows.Clear();
            using (var s = new SqlConnection(ConnectionString))
            {
                s.Open();
                var r = new SqlCommand(
                    "SELECT Termeles.Datum, Tojas.Szin, Termeles.Mennyiseg " +
                    "FROM Termeles, Tojas, Nyul " +
                    "WHERE Termeles.TipusId = Tojas.Id AND Termeles.NyulId = Nyul.Id " +
                    $"AND Nyul.Nev LIKE '{munkasNeve.Text}' " +
                    $"AND MONTH(Datum) = {honapSzam.Value} " +
                    $"ORDER BY Termeles.Datum;", s).ExecuteReader();

                while (r.Read())
                {
                    statisztikadgv.Rows.Add(r.GetDateTime(0).ToString("yyyy-MM-dd"), r[1], r[2] + "db");
                }
            }
        }

        private void munkasNeve_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r = new SqlCommand("SELECT Nev FROM Nyul;", c)
                    .ExecuteReader();
                while (r.Read()) munkasNeve.Items.Add(r[0]);
                r.Close();
                munkasNeve.SelectedIndex = 0;
                Filladatok();
            }
        }
    }
}
