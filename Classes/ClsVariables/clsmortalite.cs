using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_poullailler.Classes
{
    class clsmortalite
    {
        string idmortalite;
        string poule;
        int nombre_vivant;
        int nombre_malade;
        int nombre_mort;
        DateTime dateprelevement;

        public string Idmortalite
        {
            get
            {
                return idmortalite;
            }

            set
            {
                idmortalite = value;
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

        public int Nombre_vivant
        {
            get
            {
                return nombre_vivant;
            }

            set
            {
                nombre_vivant = value;
            }
        }

        public int Nombre_malade
        {
            get
            {
                return nombre_malade;
            }

            set
            {
                nombre_malade = value;
            }
        }

        public int Nombre_mort
        {
            get
            {
                return nombre_mort;
            }

            set
            {
                nombre_mort = value;
            }
        }

        public DateTime Dateprelevement
        {
            get
            {
                return dateprelevement;
            }

            set
            {
                dateprelevement = value;
            }
        }
    }
}
