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
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_connecter_Click(object sender, EventArgs e)
        {

            int idd;
            string rl;
            string mdf;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                MySqlCommand cmd1 = new MySqlCommand("select id,role,modifiedby from user where username=@nom  and password=@mdp", Program.cnx);
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
                    mdf = dr["modifiedby"].ToString();
                    if (rl.Equals("admin"))
                    {
                        testdashboard s = new testdashboard(idd);
                        s.Show();
                        this.Hide();
                    }
                    else
                    {
                        if (mdf.Equals("admin")) {
                            Changermdp s = new Changermdp(idd);
                            s.Show();
                            this.Hide();
                        } 
                        else { 
                        Dashboard s = new Dashboard();
                        s.Show();
                        this.Hide();}
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
        private void LinkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Bibliotheque développe des technologies et des services permettant à tous d’entrer en contact, de créer des communautés et de développer des entreprises. Les présentes Conditions régissent votre utilisation de Bibliotheque, Messenger et autres produits, fonctionnalités, applications, services, technologies et logiciels que nous proposons (les Produits Bibliotheque ou les Produits), sauf lorsque nous indiquons expressément que des conditions distinctes (et non les présentes) s’appliquent. Ces Produits vous sont fournis par Bibliotheque, Inc. Nous ne vous facturons pas l’utilisation de Bibliotheque ou des autres produits et services inclus dans les présentes Conditions.À la place, des entreprises et des organisations nous payent pour vous montrer des publicités pour leurs produits et services.En utilisant nos Produits, vous acceptez que nous vous montrions des publicités que nous croyons pertinentes pour vous en fonction de vos intérêts.Nous utilisons vos données personnelles afin de définir les publicités à vous montrer. Nous ne vendons pas vos données personnelles aux annonceurs et ne partageons pas d’informations permettant de vous identifier directement(telles que votre nom, votre adresse e - mail ou toutes autres coordonnées) avec les annonceurs, sauf autorisation expresse de votre part.À la place, les annonceurs nous donnent des informations, telles que le type d’audience à qui ils souhaitent montrer leurs publicités, et nous diffusons ces publicités auprès des personnes susceptibles d’être intéressées.Nous envoyons aux annonceurs des rapports sur les performances de leurs publicités pour les aider à comprendre comment les gens interagissent avec leur contenu.Consultez la Section 2 ci - dessous pour en savoir plus. Notre Politique d’utilisation des données explique comment nous collectons et utilisons vos données personnelles afin de définir les publicités que vous voyez et de vous fournir tous les services décrits ci - dessous.Vous pouvez également accéder à vos Paramètres à tout moment afin d’examiner les options de confidentialité dont vous disposez concernant l’utilisation que nous faisons de vos données.");
        }

        private void LinkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Bibliotheque développe des technologies et des services permettant à tous d’entrer en contact, de créer des communautés et de développer des entreprises. Les présentes Conditions régissent votre utilisation de Bibliotheque, Messenger et autres produits, fonctionnalités, applications, services, technologies et logiciels que nous proposons (les Produits Bibliotheque ou les Produits), sauf lorsque nous indiquons expressément que des conditions distinctes (et non les présentes) s’appliquent. Ces Produits vous sont fournis par Bibliotheque, Inc. Nous ne vous facturons pas l’utilisation de Bibliotheque ou des autres produits et services inclus dans les présentes Conditions.À la place, des entreprises et des organisations nous payent pour vous montrer des publicités pour leurs produits et services.En utilisant nos Produits, vous acceptez que nous vous montrions des publicités que nous croyons pertinentes pour vous en fonction de vos intérêts.Nous utilisons vos données personnelles afin de définir les publicités à vous montrer. Nous ne vendons pas vos données personnelles aux annonceurs et ne partageons pas d’informations permettant de vous identifier directement(telles que votre nom, votre adresse e - mail ou toutes autres coordonnées) avec les annonceurs, sauf autorisation expresse de votre part.À la place, les annonceurs nous donnent des informations, telles que le type d’audience à qui ils souhaitent montrer leurs publicités, et nous diffusons ces publicités auprès des personnes susceptibles d’être intéressées.Nous envoyons aux annonceurs des rapports sur les performances de leurs publicités pour les aider à comprendre comment les gens interagissent avec leur contenu.Consultez la Section 2 ci - dessous pour en savoir plus. Notre Politique d’utilisation des données explique comment nous collectons et utilisons vos données personnelles afin de définir les publicités que vous voyez et de vous fournir tous les services décrits ci - dessous.Vous pouvez également accéder à vos Paramètres à tout moment afin d’examiner les options de confidentialité dont vous disposez concernant l’utilisation que nous faisons de vos données.");
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

      

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
