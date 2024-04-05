using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Techniciens : Personne
    {
        private DateTime dateNaiss, dateEmbauche;

        public DateTime DateNaiss
        {
            get { return dateNaiss; }
            set { dateNaiss = value; }
        }
        public DateTime DateEmbauche
        {
            get { return dateEmbauche; }
            set { dateEmbauche = value; }
        }

        public Techniciens() { }
        public Techniciens(string matricule, string nom, string nationalite, string telephone, string email, string genre, DateTime dateNaiss, DateTime dateEmbauche) : 
            base( matricule, nom, nationalite,telephone,email,genre)
        {

            
            this.dateEmbauche = dateEmbauche;
            this.dateNaiss = dateNaiss;
    }
    }
}
