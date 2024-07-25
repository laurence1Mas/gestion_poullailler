using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_poullailler.Classes
{
    class clsconsommation
    {
        string codeconsommation;
        string poule;
        string aliment;
        int quantite;
        string unite;
        DateTime dateconsommation;

        public string Codeconsommation
        {
            get
            {
                return codeconsommation;
            }

            set
            {
                codeconsommation = value;
            }
        }

        public string Poule
        {
            get
            {
                return poule;
            }

            set
            {
                poule = value;
            }
        }

        public string Aliment
        {
            get
            {
                return aliment;
            }

            set
            {
                aliment = value;
            }
        }

        public int Quantite
        {
            get
            {
                return quantite;
            }

            set
            {
                quantite = value;
            }
        }

        public string Unite
        {
            get
            {
                return unite;
            }

            set
            {
                unite = value;
            }
        }

        public DateTime Dateconsommation
        {
            get
            {
                return dateconsommation;
            }

            set
            {
                dateconsommation = value;
            }
        }
    }
}
