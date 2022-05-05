using Projet_Bibliotheque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1_TP5
{
     class Periodiques : Ouvrage
    {
        private int num;
        private String nom;
        private int periodicite;

        public Periodiques(int num, string nom, int periodicite) : base()
        {
            this.num = num;
            this.nom = nom;
            this.periodicite = periodicite;
        }

        public override string ToString()
        {
            return num + " " + nom + " " + periodicite;
        }
    }
}
