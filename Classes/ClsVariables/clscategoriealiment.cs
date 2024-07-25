using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_poullailler.Classes
{
    class clscategoriealiment
    {
        string idcatealiment;
        string designation;

        public string Idcatealiment
        {
            get
            {
                return idcatealiment;
            }

            set
            {
                idcatealiment = value;
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
