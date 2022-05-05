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
    public partial class Changermdp : Form
    {
        private int id;
        public Changermdp(int id)
        {
            this.id = id;
            Program.cnx.Close();
            InitializeComponent();
            LoadUser();
        }
        private void LoadUser()
        {
            MySqlCommand cmd1 = new MySqlCommand("select username,email from user where id=@i", Program.cnx);

            MySqlParameter[] mmm = new MySqlParameter[1];
            mmm[0] = new MySqlParameter("@i", id);
            cmd1.Parameters.AddRange(mmm);
            Program.cnx.Open();
            MySqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {

                Label5.Text = "Bienvenue " + dr["username"].ToString();
            }
            dr.Close();
            Program.cnx.Close();

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_connecter_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    MySqlCommand scmd = new MySqlCommand("UPDATE user SET modifiedby=@c,password=@a WHERE id=@e ", Program.cnx);
                    MySqlParameter[] sp = new MySqlParameter[3];
                    sp[0] = new MySqlParameter("@c", "user");
                    sp[1] = new MySqlParameter("@a", textBox1.Text);
                    sp[2] = new MySqlParameter("@e", id);
                    scmd.Parameters.AddRange(sp);
                    Program.cnx.Open();
                    int n = scmd.ExecuteNonQuery();
                    Program.cnx.Close();
                    if (n != 0)
                    {
                        MessageBox.Show("Bien Modifier ", "Affermation", MessageBoxButtons.OK, MessageBoxIcon.None);
                        textBox1.Clear();
                        textBox2.Clear();
                        Dashboard d = new Dashboard();
                        d.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Error de modifiction ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Mot de passe n'est pas identique", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
