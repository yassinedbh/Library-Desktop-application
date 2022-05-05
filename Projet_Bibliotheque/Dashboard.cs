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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Livreform l = new Livreform();
            l.Show();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Cdform l = new Cdform();
            l.Show();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Periodiciteform l = new Periodiciteform();
            l.Show();
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Empruntform l = new Empruntform();
            l.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Utilisateurform l = new Utilisateurform();
            l.Show();
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
                RendreOuvrage l = new RendreOuvrage();
            l.Show();
            this.Close();
        }
    }
}
