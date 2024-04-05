using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Materiel
    {
        private String idmat, numeroSerie, marque , photo ,commentaire;

        public string Idmat
        {
            get { return idmat; }
            set { idmat = value; }
        }
        public string NumeroSerie
        {
            get { return numeroSerie; }
            set { numeroSerie = value; }
        }
        public string Marque
        {
            get { return marque; }
            set { marque = value; }
        }
        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }
        public string Commentaire
        {
            get { return commentaire; }
            set { commentaire = value; }
        }
    }
}
