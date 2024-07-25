using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_poullailler.Classes
{
    class clscategoriemedicament
    {
        string idcategorie;
        string designation;

        public string Idcategorie
        {
            get
            {
                return idcategorie;
            }

            set
            {
                idcategorie = value;
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
    }
}
