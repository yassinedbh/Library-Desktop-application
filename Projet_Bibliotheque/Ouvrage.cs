using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projet_Bibliotheque
{
     abstract class Ouvrage
    {
        private int cote;
        static public int cmp = 0;

        public int Cote { get => cote; set => cote = value; }

        public Ouvrage()
        {
            this.cote = ++cmp;
        }

        public virtual string toString() {
            return "";
        }
       
    }

}
