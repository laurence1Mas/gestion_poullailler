using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_poullailler.Classes
{
    class clsfournisseur
    {
        string codefournisseur;
        string noms;
        string genre;
        string adresse;
        string telephone;
        string mail;

        public string Codefournisseur
        {
            get
            {
                return codefournisseur;
            }

            set
            {
                codefournisseur = value;
            }
        }

        public string Noms
        {
            get
            {
                return noms;
            }

            set
            {
                noms = value;
            }
        }

        public string Genre
        {
            get
            {
                return genre;
            }

            set
            {
                genre = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string Telephone
        {
            get
            {
                return telephone;
            }

            set
            {
                telephone = value;
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }
    }
}
