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
    public partial class Utilisateurform : Form
    {
        int index;
        public Utilisateurform()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Load();
        }
        private void Load()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select id,username,email,password from  user where role='user' ", Program.cnx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;

        }
        private void Button5_Click(object sender, EventArgs e)
        {
            Dashboard l = new Dashboard();
            l.Show();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox4.Text)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    MySqlCommand scmd = new MySqlCommand("insert into user values(null,@c,@mtp,@a,@r,@mod)", Program.cnx);
                    MySqlParameter[] sp = new MySqlParameter[5];
                    sp[0] = new MySqlParameter("@c", textBox1.Text);
                    sp[1] = new MySqlParameter("@mtp", textBox2.Text);
                    sp[2] = new MySqlParameter("@a", textBox3.Text);
                    sp[3] = new MySqlParameter("@r", "user");
                    sp[4] = new MySqlParameter("@mod", "admin");
                    scmd.Parameters.AddRange(sp);
                    Program.cnx.Open();
                    int n = scmd.ExecuteNonQuery();
                    Program.cnx.Close();
                    if (n != 0)
                    {
                        MessageBox.Show("Bien Ajouter ", "Affermation", MessageBoxButtons.OK, MessageBoxIcon.None);
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        Load();
                    }

                    else
                    {
                        MessageBox.Show("Error d'ajout ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
                else
                {
                    MessageBox.Show("Remplir les champs", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Mot de passe n'est pas identique", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox4.Text)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    MySqlCommand scmd = new MySqlCommand("UPDATE user SET username=@c,email=@mtp,password=@a WHERE id=@e ", Program.cnx);
                    MySqlParameter[] sp = new MySqlParameter[4];
                    sp[0] = new MySqlParameter("@c", textBox1.Text);
                    sp[1] = new MySqlParameter("@mtp", textBox2.Text);
                    sp[2] = new MySqlParameter("@a", textBox3.Text);
                    sp[3] = new MySqlParameter("@e", index);
                    scmd.Parameters.AddRange(sp);
                    Program.cnx.Open();
                    int n = scmd.ExecuteNonQuery();
                    Program.cnx.Close();
                    if (n != 0)
                    {
                        MessageBox.Show("Bien Modifier ", "Affermation", MessageBoxButtons.OK, MessageBoxIcon.None);
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        button2.Enabled = false;
                        button3.Enabled = false;
                        Button1.Enabled = true;
                        Load();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de supprimer l'utilisateur", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MySqlCommand cmd = new MySqlCommand("delete from user where id=@id", Program.cnx);
                MySqlParameter p = new MySqlParameter("@id", index);
                cmd.Parameters.Add(p);
                Program.cnx.Open();
                int r = cmd.ExecuteNonQuery();
                Program.cnx.Close();
                if (r != 0)
                {
                    MessageBox.Show("Bien supprimer", "Affirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button2.Enabled = false;
                    button3.Enabled = false;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();

                    Load();
                }
                else
                {
                    MessageBox.Show("Erreur suppression 'Error' ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            index = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            button2.Enabled = true;
            button3.Enabled = true;
            Button1.Enabled = false;
        }

        private void Utilisateurform_Load(object sender, EventArgs e)
        {

        }
    }
}
        
   
