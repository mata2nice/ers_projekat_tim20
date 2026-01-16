using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Modeli
{
    public class Biljka
    {
        public long Id { get; set; }
        public string Naziv { get; set; }
        public double Kolicina { get; set; }   // npr. kg ili broj sadnica
        public double JacinaArome { get; set; } // 0–100

        public Biljka() { }

        public Biljka(string naziv, double kolicina, double jacinaArome)
        {
            Naziv = naziv;
            Kolicina = kolicina;
            JacinaArome = jacinaArome;
        }
    }
}
