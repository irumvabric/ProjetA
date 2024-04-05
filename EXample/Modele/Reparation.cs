using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Reparation
    {
        DateTime date;
        string panne;
        int cout;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Panne
        {
            get { return panne; }
            set { panne = value; }
        }
        public int Cout
        {
            get { return cout; }
            set { cout = value; }
        }
    }
}
