using Projet_Bibliotheque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1_TP5
{
    internal class Cds : Ouvrage
    {
        private String auteur;
        private String titre;

        public Cds(string auteur, string titre) : base()
        {
            this.auteur = auteur;
            this.titre = titre;
        }

        public override string ToString()
        {
            return auteur +" "+ titre;
        }
    }
}
