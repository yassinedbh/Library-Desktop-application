using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Bibliotheque
{
    public partial class Listestouteemprunts : Form
    {
        public Listestouteemprunts()
        {
            InitializeComponent();
            LoadEmprunt();
        }

        private void Listestouteemprunts_Load(object sender, EventArgs e)
        {

        }
        private void LoadEmprunt()
        {
            MySqlDataAdapter dq = new MySqlDataAdapter("select * from  emprunt ", Program.cnx);
            DataTable ds = new DataTable();
            dq.Fill(ds);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds;

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            RendreOuvrage l = new RendreOuvrage();
            l.Show();
            this.Close();
        }
    }
}
