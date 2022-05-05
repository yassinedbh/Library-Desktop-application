using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Bibliotheque
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authentification());
        }
        public static MySqlConnection cnx = new MySqlConnection("SERVER=127.0.0.1; DATABASE=bibliothèque; UID=root; PASSWORD= ;  pooling = false; convert zero datetime=True");
    }
}

