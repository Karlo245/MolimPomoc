using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolimPomoc
{
    public class Igraci
    {
        public string ime;
        public string prezime;
        public string pozicija;
        public int broj;

        public Igraci(string ime, string prezime, string pozicija, int broj)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.pozicija = pozicija;
            this.broj = broj;
        }

        public override string ToString()
        {
            return ime + " " + prezime + " - " + pozicija + " (" + broj + ")";
        }

    }
}
