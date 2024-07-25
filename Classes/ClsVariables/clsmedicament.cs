using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_poullailler.Classes
{
    class clsmedicament
    {
        string codemedicament;
        string categoriemedicament;
        string designation;

        public string Codemedicament
        {
            get
            {
                return codemedicament;
            }

            set
            {
                codemedicament = value;
            }
        }

        public string Categoriemedicament
        {
            get
            {
                return categoriemedicament;
            }

            set
            {
                categoriemedicament = value;
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
