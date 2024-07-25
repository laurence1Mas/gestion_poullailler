using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_poullailler.Classes
{
    class clscommande
    {
        string codecommande;
        string client;
        string poule;
        int quantite;
        decimal prixu;
        DateTime datecommande;

        public string Codecommande
        {
            get
            {
                return codecommande;
            }

            set
            {
                codecommande = value;
            }
        }

        public string Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
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

        public DateTime Datecommande
        {
            get
            {
                return datecommande;
            }

            set
            {
                datecommande = value;
            }
        }
    }
}
