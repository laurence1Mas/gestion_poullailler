using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_poullailler.Classes
{
    class clspoule
    {
        string codepole;
        string categoriepoule;
        string designation;
        int quantite;
        decimal poids;
        string unite;
        decimal prixu;

        public string Codepole
        {
            get
            {
                return codepole;
            }

            set
            {
                codepole = value;
            }
        }

        public string Categoriepoule
        {
            get
            {
                return categoriepoule;
            }

            set
            {
                categoriepoule = value;
            }
        }

        public string Designation
        {
            get
            {
                return designation;
            }

            set
            {
                designation = value;
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

        public decimal Poids
        {
            get
            {
                return poids;
            }

            set
            {
                poids = value;
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

        public decimal Prixu
        {
            get
            {
                return prixu;
            }

            set
            {
                prixu = value;
            }
        }
    }
}
