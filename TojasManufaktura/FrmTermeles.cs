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
    public partial class FrmTermeles : Form
    {
        public string ConnectionString { get; private set; }
        public FrmTermeles(string connectionString)
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
            using (var s = new SqlConnection(ConnectionString))
            {
                adatok.Rows.Clear();
                s.Open();
                var r = new SqlCommand(
                    "SELECT Termeles.Datum, Tojas.Szin, Termeles.Mennyiseg, Nyul.Nev " +
                    "FROM Termeles, Tojas, Nyul " +
                    "WHERE Termeles.TipusId = Tojas.Id AND Termeles.NyulId = Nyul.Id " +
                    "ORDER BY Datum ASC;", s).ExecuteReader();

                while (r.Read())
                {
                    adatok.Rows.Add(r.GetDateTime(0).ToString("yyyy-MM-dd"), r[1], r[2] + "db", r[3]);
                }
                s.Close();
            }            
        }

        private void FrmTermeles_Load(object sender, EventArgs e)
        {
            Filladatok();

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var reader = new SqlCommand("SELECT Szin FROM Tojas;", connection)
                    .ExecuteReader();
                while (reader.Read()) tojasSzam.Items.Add(reader[0]);
                reader.Close();

                reader = new SqlCommand("SELECT Nev FROM Nyul;", connection)
                    .ExecuteReader();
                while (reader.Read()) munkasBox.Items.Add(reader[0]);
                reader.Close();

                tojasSzam.SelectedIndex = 0;
                munkasBox.SelectedIndex = 0;
            }
        }
        private void felvetel_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var reader = new SqlCommand(
                    $"SELECT Id FROM Nyul WHERE Nev LIKE '{munkasBox.Text}';",
                    connection).ExecuteReader();
                reader.Read();
                int nyulID = reader.GetInt32(0);
                reader.Close();

                reader = new SqlCommand(
                    $"SELECT Id FROM Tojas WHERE Szin LIKE '{tojasSzam.Text}';",
                    connection).ExecuteReader();
                reader.Read();
                int tojasID = reader.GetInt32(0);
                reader.Close();

                new SqlCommand(
                    "INSERT INTO Termeles VALUES " +
                    $"('{datumPicker.Value.ToString("yyyy-MM-dd")}', {tojasID}, {nyulID}, {mennyiButton.Value});",
                    connection).ExecuteNonQuery();

                MessageBox.Show("bejegyzés rögzítése megtörtént!");

                Filladatok();
            }
        }


    }
}
