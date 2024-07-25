using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_poullailler.Classes
{
    class clstraitement
    {
        string codetraitement;
        string poule;
        string medicament;
        int dose;
        string unite;
        DateTime datetraitement;

        public string Codetraitement
        {
            get
            {
                return codetraitement;
            }

            set
            {
                codetraitement = value;
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

        public string Medicament
        {
            get
            {
                return medicament;
            }

            set
            {
                medicament = value;
            }
        }

        public int Dose
        {
            get
            {
                return dose;
            }

            set
            {
                dose = value;
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

        public DateTime Datetraitement
        {
            get
            {
                return datetraitement;
            }

            set
            {
                datetraitement = value;
            }
        }
    }
}
