using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planer
{
    class Zaposlenik
    {
        int id;
        string ime;
        string prezime;
        string korisnickaOznaka;
        string lozinka;
       



        public Zaposlenik()
        {

        }

        public Zaposlenik(int id_zaposlenika, string ime_zaposlenika,string prezime_zaposlenika)
        {
            Id = id_zaposlenika;
            Ime = ime_zaposlenika;
            Prezime = prezime_zaposlenika;

        }

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string KorisnickaOznaka { get => korisnickaOznaka; set => korisnickaOznaka = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
    }
}
