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
    public partial class Motdepasseform : Form
    {
        string resultat2;
        public Motdepasseform()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MySqlCommand msqlq = new MySqlCommand("SELECT password as pass FROM user WHERE email = @b", Program.cnx);
            MySqlParameter[] mmm = new MySqlParameter[1];
            mmm[0] = new MySqlParameter("@b", TextBox1.Text);
            msqlq.Parameters.AddRange(mmm);
            Program.cnx.Open();
            MySqlDataReader dr = msqlq.ExecuteReader();
            if (dr.Read())
            {
                resultat2 = dr["pass"].ToString();
            }
            dr.Close();
            Program.cnx.Close();
            if(resultat2 != null)
            {
MessageBox.Show("Votre mot de passe est " + resultat2 , "Affermation", MessageBoxButtons.OK, MessageBoxIcon.None);
                TextBox1.Clear();
                Form1 l = new Form1();
                l.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Utilisateur n'existe pas dans la base donné", "Affermation", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 l = new Form1();
            l.Show();
            this.Close();
        }
    }
}
