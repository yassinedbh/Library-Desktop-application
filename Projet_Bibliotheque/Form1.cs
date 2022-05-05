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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_connecter_Click(object sender, EventArgs e)
        {
            int idd;
            string rl;

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                MySqlCommand cmd1 = new MySqlCommand("select id,role from user where username=@nom  and password=@mdp", Program.cnx);
                MySqlParameter[] p = new MySqlParameter[2];
                p[0] = new MySqlParameter("@nom", textBox1.Text);
                p[1] = new MySqlParameter("@mdp", textBox2.Text);
                cmd1.Parameters.AddRange(p);
                Program.cnx.Open();
                MySqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    idd = int.Parse(dr["id"].ToString());
                    rl = dr["role"].ToString();
                    if (rl.Equals("admin")) { 
                    testdashboard s = new testdashboard(idd);
                    s.Show();
                    this.Hide();
                    }
                    else
                    {
                        Dashboard s = new Dashboard();
                        s.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Utilisateur n'existe pas veuillez creer un nouveau compte", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                dr.Close();
                Program.cnx.Close();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tout les champs", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                textBox5.PasswordChar = '\0';
            }
            else
            {
                textBox5.PasswordChar = '•';
            }
        }

        private void btn_inscription_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                bool test = false;
                    bool s = true;
                    MySqlCommand cmd = new MySqlCommand("select username,email,password from user where username=@u and email=@em and password=@mdp", Program.cnx);
                    MySqlParameter[] p = new MySqlParameter[3];
                    p[0] = new MySqlParameter("@u", textBox3.Text);
                    p[1] = new MySqlParameter("@em", textBox4.Text);
                    p[2] = new MySqlParameter("@mdp", textBox5.Text);
                    cmd.Parameters.AddRange(p);
                    Program.cnx.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        s = false;
                    }
                    dr.Close();
                    Program.cnx.Close();
                    if (s)
                    {
                        MySqlCommand scmd = new MySqlCommand("insert into user (username,email,password) values(@u,@em,@mdp)", Program.cnx);
                        MySqlParameter[] sp = new MySqlParameter[3];
                        sp[0] = new MySqlParameter("@u", textBox3.Text);
                        sp[1] = new MySqlParameter("@em", textBox4.Text);
                        sp[2] = new MySqlParameter("@mdp", textBox5.Text);
                        scmd.Parameters.AddRange(sp);
                        Program.cnx.Open();
                        int n = scmd.ExecuteNonQuery();
                        Program.cnx.Close();
                        if (n != 0)
                            if (MessageBox.Show("Ajout avec succes ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                            {
                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox5.Text = "";
                        }
                            else
                                MessageBox.Show("Error d'ajout ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (MessageBox.Show("Utilisateur existe deja ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                            textBox1.Focus();
                        }
                    }
                } else {
                MessageBox.Show("veuillez remplir toute les champs", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Motdepasseform s = new Motdepasseform();
            s.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Bibliotheque développe des technologies et des services permettant à tous d’entrer en contact, de créer des communautés et de développer des entreprises. Les présentes Conditions régissent votre utilisation de Bibliotheque, Messenger et autres produits, fonctionnalités, applications, services, technologies et logiciels que nous proposons (les Produits Bibliotheque ou les Produits), sauf lorsque nous indiquons expressément que des conditions distinctes (et non les présentes) s’appliquent. Ces Produits vous sont fournis par Bibliotheque, Inc. Nous ne vous facturons pas l’utilisation de Bibliotheque ou des autres produits et services inclus dans les présentes Conditions.À la place, des entreprises et des organisations nous payent pour vous montrer des publicités pour leurs produits et services.En utilisant nos Produits, vous acceptez que nous vous montrions des publicités que nous croyons pertinentes pour vous en fonction de vos intérêts.Nous utilisons vos données personnelles afin de définir les publicités à vous montrer. Nous ne vendons pas vos données personnelles aux annonceurs et ne partageons pas d’informations permettant de vous identifier directement(telles que votre nom, votre adresse e - mail ou toutes autres coordonnées) avec les annonceurs, sauf autorisation expresse de votre part.À la place, les annonceurs nous donnent des informations, telles que le type d’audience à qui ils souhaitent montrer leurs publicités, et nous diffusons ces publicités auprès des personnes susceptibles d’être intéressées.Nous envoyons aux annonceurs des rapports sur les performances de leurs publicités pour les aider à comprendre comment les gens interagissent avec leur contenu.Consultez la Section 2 ci - dessous pour en savoir plus. Notre Politique d’utilisation des données explique comment nous collectons et utilisons vos données personnelles afin de définir les publicités que vous voyez et de vous fournir tous les services décrits ci - dessous.Vous pouvez également accéder à vos Paramètres à tout moment afin d’examiner les options de confidentialité dont vous disposez concernant l’utilisation que nous faisons de vos données.");
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Bibliotheque développe des technologies et des services permettant à tous d’entrer en contact, de créer des communautés et de développer des entreprises. Les présentes Conditions régissent votre utilisation de Bibliotheque, Messenger et autres produits, fonctionnalités, applications, services, technologies et logiciels que nous proposons (les Produits Bibliotheque ou les Produits), sauf lorsque nous indiquons expressément que des conditions distinctes (et non les présentes) s’appliquent. Ces Produits vous sont fournis par Bibliotheque, Inc. Nous ne vous facturons pas l’utilisation de Bibliotheque ou des autres produits et services inclus dans les présentes Conditions.À la place, des entreprises et des organisations nous payent pour vous montrer des publicités pour leurs produits et services.En utilisant nos Produits, vous acceptez que nous vous montrions des publicités que nous croyons pertinentes pour vous en fonction de vos intérêts.Nous utilisons vos données personnelles afin de définir les publicités à vous montrer. Nous ne vendons pas vos données personnelles aux annonceurs et ne partageons pas d’informations permettant de vous identifier directement(telles que votre nom, votre adresse e - mail ou toutes autres coordonnées) avec les annonceurs, sauf autorisation expresse de votre part.À la place, les annonceurs nous donnent des informations, telles que le type d’audience à qui ils souhaitent montrer leurs publicités, et nous diffusons ces publicités auprès des personnes susceptibles d’être intéressées.Nous envoyons aux annonceurs des rapports sur les performances de leurs publicités pour les aider à comprendre comment les gens interagissent avec leur contenu.Consultez la Section 2 ci - dessous pour en savoir plus. Notre Politique d’utilisation des données explique comment nous collectons et utilisons vos données personnelles afin de définir les publicités que vous voyez et de vous fournir tous les services décrits ci - dessous.Vous pouvez également accéder à vos Paramètres à tout moment afin d’examiner les options de confidentialité dont vous disposez concernant l’utilisation que nous faisons de vos données.");
        }
    }
    }

