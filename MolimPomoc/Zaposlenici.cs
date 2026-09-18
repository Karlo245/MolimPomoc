using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolimPomoc
{
    public class Zaposlenici
    {
        public string ime;
        public string prezime;
        public string posao;
        public int plaća;

        public Zaposlenici(string ime, string prezime, string posao, int plaća)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.posao = posao;
            this.plaća = plaća;
        }
    }

}
