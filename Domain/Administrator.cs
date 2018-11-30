using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Administrator
    {
        int id;
        string korisnicka_oznaka;
        string lozinka;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Korisnicka_Oznaka
        {
            get { return korisnicka_oznaka; }
            set { korisnicka_oznaka = value; }
        }

        public string Lozinka
        {
            get { return lozinka; }
            set { lozinka = value; }
        }
    }
}
