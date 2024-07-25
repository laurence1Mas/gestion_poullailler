using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_poullailler.Classes
{
    class clscategoriepoule
    {
        string idcatepoule;
        string designation;

        public string Idcatepoule
        {
            get
            {
                return idcatepoule;
            }

            set
            {
                idcatepoule = value;
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
