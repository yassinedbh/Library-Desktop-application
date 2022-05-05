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
    public partial class testdashboard : Form
    {
        private int id;

        public testdashboard(int id)
        {
            InitializeComponent();
            this.id=id;
            openChildForm(new Statistique());
            pnlNav.Height = button1.Height;
            pnlNav.Top = button1.Top;
            pnlNav.Left = button1.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);
            Program.cnx.Close();
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

                    label1.Text = dr["username"].ToString();
                    label2.Text = dr["email"].ToString();
            }
                dr.Close();
                Program.cnx.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button1.Height;
            pnlNav.Top = button1.Top;
            pnlNav.Left = button1.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new Statistique());
        }

        private void testdashboard_Load(object sender, EventArgs e)
        {

        }

        public  Form activeForm = null;


        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button2.Height;
            pnlNav.Top = button2.Top;
            pnlNav.Left = button2.Left;
            button2.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new Utilisateurform());
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button5.Height;
            pnlNav.Top = button5.Top;
            pnlNav.Left = button5.Left;
            button5.BackColor = Color.FromArgb(46, 51, 73);
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(24, 30, 54);
        }

       

        private void button5_Leave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Authentification form1 = new Authentification();
            form1.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
