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
    public partial class EmpruntRetard : Form
    {
        private string Date;
        public EmpruntRetard()
        {
            InitializeComponent();
            LoadEmprunt();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            RendreOuvrage l = new RendreOuvrage();
            l.Show();
            this.Close();
        }
        private void LoadEmprunt()
        {
       
          
            MySqlDataAdapter dq = new MySqlDataAdapter("select * from  emprunt where dateRetour is  NULL and NOW() > FinEmprunt ", Program.cnx);
            DataTable ds = new DataTable();
            dq.Fill(ds);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds;

        }
        private void EmpruntRetard_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
