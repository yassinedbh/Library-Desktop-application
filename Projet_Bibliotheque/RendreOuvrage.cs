using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Bibliotheque
{
    public partial class RendreOuvrage : Form
    {
        private DateTime d;
        private string format;
        private int index = 0;
        private int resultat;
        string type;
        public RendreOuvrage()
        {
            InitializeComponent();
            LoadEmprunt();
            d = new DateTime();
        }

        private void LoadEmprunt()
        {
            MySqlDataAdapter dq = new MySqlDataAdapter("select * from  emprunt where dateRetour is NULL ", Program.cnx);
            DataTable ds = new DataTable();
            dq.Fill(ds);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Button1.Enabled = true;
            type = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        private void ajouterquantite(string t, int i)
        {
            MySqlCommand scmd = new MySqlCommand("UPDATE " + t + " set quantite=quantite+1 WHERE id=@e ", Program.cnx);
            MySqlParameter[] spa = new MySqlParameter[1];
            spa[0] = new MySqlParameter("@e", i);
            scmd.Parameters.AddRange(spa);
            Program.cnx.Open();
            int m = scmd.ExecuteNonQuery();
            Program.cnx.Close();
            if (m != 0)
            {
                MessageBox.Show("La qantite est modifier ", "Affermation", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (index != 0)
            {

                MySqlCommand scmd = new MySqlCommand("UPDATE emprunt SET dateRetour=@c WHERE id=@e and @c < FinEmprunt and @c > DebutEmprunt ", Program.cnx);
                MySqlParameter[] sp = new MySqlParameter[2];
                sp[0] = new MySqlParameter("@c", dateTimePicker1.Value);
                sp[1] = new MySqlParameter("@e", index);
                scmd.Parameters.AddRange(sp);
                Program.cnx.Open();
                int n = scmd.ExecuteNonQuery();
                Program.cnx.Close();
                if (n != 0)
                {
                    MessageBox.Show("Bien Modifier ", "Affermation", MessageBoxButtons.OK, MessageBoxIcon.None);
                    ajouterquantite(type, index);
                    LoadEmprunt();
                    Button1.Enabled = false;
                }

                else
                {
                    MessageBox.Show("Error de Modification ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un element ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void testdate()
        {
            MySqlCommand msqlq = new MySqlCommand("SELECT FinEmprunt FROM emprunt WHERE id = @b", Program.cnx);
            MySqlParameter[] mmm = new MySqlParameter[1];
            mmm[0] = new MySqlParameter("@b", index);
            msqlq.Parameters.AddRange(mmm);
            Program.cnx.Open();
            MySqlDataReader dr = msqlq.ExecuteReader();
            if (dr.Read())
            { 

               
            }
            dr.Close();
            Program.cnx.Close();
        }

        private void RendreOuvrage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listestouteemprunts l = new Listestouteemprunts();
            l.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmpruntRetard l = new EmpruntRetard();
            l.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard l = new Dashboard();
            l.Show();
            this.Close();
        }
    }
    }

