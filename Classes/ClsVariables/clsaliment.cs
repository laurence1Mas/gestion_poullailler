using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_poullailler.Classes
{
    class clsaliment
    {
        string codealiment;
        string categoriealiment;
        string designation;
        string fournisseur;
        int quantite;
        string unite;
        decimal prixu;

        public string Codealiment
        {
            get
            {
                return codealiment;
            }

            set
            {
                codealiment = value;
            }
        }

        public string Categoriealiment
        {
            get
            {
                return categoriealiment;
            }

            set
            {
                categoriealiment = value;
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

        public string Fournisseur
        {
            get
            {
                return fournisseur;
            }

            set
            {
                fournisseur = value;
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
