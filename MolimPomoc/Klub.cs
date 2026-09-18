using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolimPomoc
{
    public class Klub
    {
        public string Ime;
        public List<Igraci> Igraci;
        public List<Zaposlenici> Zaposlenici;
        public int novac;

        public Klub(string ime, int novac)
        {
            Ime = ime;
            Igraci = new List<Igraci>();
            Zaposlenici = new List<Zaposlenici>();
        }

        public Klub()
        {
            Ime = "retard";
            Igraci = new List<Igraci>();
            Zaposlenici = new List<Zaposlenici>();
        }
    }
}
