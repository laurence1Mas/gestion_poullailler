using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_poullailler.Classes
{
    class clslivraison
    {
        string codelivraison;
        string commande;
        string agent;
        int quantite;
        decimal prixu;
        string lieulivraison;
        DateTime datelivraison;

        public string Codelivraison
        {
            get
            {
                return codelivraison;
            }

            set
            {
                codelivraison = value;
            }
        }

        public string Commande
        {
            get
            {
                return commande;
            }

            set
            {
                commande = value;
            }
        }

        public string Agent
        {
            get
            {
                return agent;
            }

            set
            {
                agent = value;
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

        public string Lieulivraison
        {
            get
            {
                return lieulivraison;
            }

            set
            {
                lieulivraison = value;
            }
        }

        public DateTime Datelivraison
        {
            get
            {
                return datelivraison;
            }

            set
            {
                datelivraison = value;
            }
        }
    }
}
