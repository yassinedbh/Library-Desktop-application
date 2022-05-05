using MySql.Data.MySqlClient;
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

namespace Projet_Bibliotheque
{
    public partial class Empruntform : Form
    {
        int idlivre;
        static int  compare;
        int quant;
        int index=0;
        int resultat2;
        string type;
        int nbremprunt;
        bool testex;
        int qttt;
        public Empruntform()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadEmprunt();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void LoadEmprunt()
        {
            MySqlDataAdapter dq = new MySqlDataAdapter("select * from  emprunt where dateRetour is NULL ", Program.cnx);
            DataTable ds = new DataTable();
            dq.Fill(ds);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds;
            button3.Enabled = true;
        }
        private void loadLivre()
        {
            MySqlDataAdapter de = new MySqlDataAdapter("select * from livre  ", Program.cnx);

            DataTable dr = new DataTable();
            de.Fill(dr);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dr;
        }
        private void loadcd()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from  cd  ", Program.cnx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
        }
        private void loadperiodicite()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from  periodicite  ", Program.cnx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                type = "livre";
                CheckBox2.Checked = false;
                CheckBox3.Checked = false;
                button3.Enabled = false;
                loadLivre();
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked)
            {
                type = "cd";
                CheckBox1.Checked = false;
                CheckBox3.Checked = false;
                button3.Enabled = false;
                loadcd();

            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox3.Checked)
            {
                type = "periodicite";
                CheckBox2.Checked = false;
                CheckBox1.Checked = false;
                button3.Enabled = false;
                loadperiodicite();
            }
        }
             private void testquantite()
        {
            MySqlCommand msqlq = new MySqlCommand("SELECT quantite FROM "+ type +" WHERE id = @b", Program.cnx);
            MySqlParameter[] mmm = new MySqlParameter[1];
            mmm[0] = new MySqlParameter("@b", index);
            msqlq.Parameters.AddRange(mmm);
            Program.cnx.Open();
            MySqlDataReader dr = msqlq.ExecuteReader();
            if (dr.Read())
            {
                quant = int.Parse(dr["quantite"].ToString());
            }
            dr.Close();
            Program.cnx.Close();
        }
      
        private void nbreemprunt(string t)
        {
            MySqlCommand msqlq = new MySqlCommand("SELECT COUNT(*) as nbremprunt FROM emprunt WHERE cin = @b", Program.cnx);
            MySqlParameter[] mmm = new MySqlParameter[1];
            mmm[0] = new MySqlParameter("@b", t);
            msqlq.Parameters.AddRange(mmm);
            Program.cnx.Open();
            MySqlDataReader dr = msqlq.ExecuteReader();
            if (dr.Read())
            {
                resultat2 = int.Parse(dr["nbremprunt"].ToString());
            }
            dr.Close();
            Program.cnx.Close();
        }

        private void testexistance(string t,int d,string e)
        {
            MySqlCommand msqlq = new MySqlCommand("SELECT id FROM emprunt WHERE cin = @b and idouvrage =@o and typeouvrage=@t", Program.cnx);
            MySqlParameter[] mmm = new MySqlParameter[3];
            mmm[0] = new MySqlParameter("@b", t);
            mmm[1] = new MySqlParameter("@o", d);
            mmm[2] = new MySqlParameter("@t", e);
            msqlq.Parameters.AddRange(mmm);
            Program.cnx.Open();
            MySqlDataReader dr = msqlq.ExecuteReader();
            if (dr.Read())
            {
                testex = true;
            }
            else
            {
                testex = false;
            }
            dr.Close();
            Program.cnx.Close();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
             compare = DateTime.Compare(dateTimePicker1.Value, dateTimePicker2.Value);
           
            if (textBox1.Text != "" && index != 0 && (CheckBox3.Checked || CheckBox2.Checked || CheckBox1.Checked))
            {
               
       
                if (compare < 0)
                {
                    nbreemprunt(textBox1.Text);
                    testquantite();
                    testexistance(textBox1.Text, index, type);
                    if (resultat2 < 3)
                    {
                        if (quant > 0)
                        {
                            if (testex == false)
                            {
                                MySqlCommand scmd = new MySqlCommand("insert into emprunt (cin,idouvrage,DebutEmprunt,FinEmprunt,typeouvrage) values(@u,@o,@d,@d2,@d5)", Program.cnx);
                                MySqlParameter[] sp = new MySqlParameter[5];
                                sp[0] = new MySqlParameter("@u", textBox1.Text);
                                sp[1] = new MySqlParameter("@o", index);
                                sp[2] = new MySqlParameter("@d", dateTimePicker1.Value);
                                sp[3] = new MySqlParameter("@d2", dateTimePicker2.Value);
                                sp[4] = new MySqlParameter("@d5", type);

                                scmd.Parameters.AddRange(sp);
                                Program.cnx.Open();
                                int n = scmd.ExecuteNonQuery();
                                Program.cnx.Close();
                                if (n != 0)
                                {
                                    MessageBox.Show("Ajout avec succes ", "Affermation", MessageBoxButtons.OK, MessageBoxIcon.None);

                                    changequantite(type, index);
                                    LoadEmprunt();
                                    textBox1.Clear();
                                    CheckBox3.Checked = false;
                                    CheckBox2.Checked = false;
                                    CheckBox1.Checked = false;


                                    




                                }

                                else
                                {
                                    MessageBox.Show("Erreur d'ajout ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Le client a deja emprunter ce livre", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Quantite insuffisante", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("l'utilisateur a depasser le nombre d'emprunt possible", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("La date de retour doit etre > date emprunt", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                MessageBox.Show("Veuillez remplire tout les champs ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Dashboard l = new Dashboard();
            l.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            index = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
           
        }
        private void changequantite(string t,int i )
        {
            MySqlCommand scmd = new MySqlCommand("UPDATE " + t + " set quantite=quantite-1 WHERE id=@e ", Program.cnx);
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
        


        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de supprimer ce ouvrage", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MySqlCommand cmd = new MySqlCommand("delete from emprunt where id=@id", Program.cnx);
                MySqlParameter p = new MySqlParameter("@id", index);
                cmd.Parameters.Add(p);
                Program.cnx.Open();
                int r = cmd.ExecuteNonQuery();
                Program.cnx.Close();
                if (r != 0)
                {
                    MessageBox.Show("Bien supprimer", "Affirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button3.Enabled = false;

                    LoadEmprunt();
                }
                else
                {
                    MessageBox.Show("Erreur suppression 'Error' ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Empruntform_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadEmprunt();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Empruntform_Load_1(object sender, EventArgs e)
        {

        }
    }
}
