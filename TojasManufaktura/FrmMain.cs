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
    public partial class FrmMain : Form
    {
        public string ConnectionString { get; private set; }
        public FrmMain()
        {
            InitializeComponent();
        }

        private void kilepes_Click(object sender, EventArgs e)
         => Application.Exit();

        private void termeles_Click(object sender, EventArgs e)
         => new FrmTermeles(ConnectionString).ShowDialog();

        private void statisztika_Click(object sender, EventArgs e)
         => new FrmStatisztika(ConnectionString).ShowDialog();
    }
}
