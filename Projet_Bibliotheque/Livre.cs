using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliotheque
{
    class Livre : Ouvrage

    {
        private String auteur;
        private String titre;
        private String editeur;


        public Livre(string auteur, string titre, string editeur) : base()
        {
            this.auteur = auteur;
            this.titre = titre;
            this.editeur = editeur;
        }

        public override string ToString()
        {
            return auteur + " " + titre + " " + editeur;
        }
    }
}
