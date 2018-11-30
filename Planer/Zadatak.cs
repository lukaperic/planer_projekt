using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planer
{
    class Zadatak
    {
        int id;
        string naziv;
        string opis_zadatka;
        string rok;

        public Zadatak()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Opis_zadatka { get => opis_zadatka; set => opis_zadatka = value; }
        public string Rok { get => rok; set => rok = value; }
    }
}
