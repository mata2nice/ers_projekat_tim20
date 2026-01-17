using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.BazaPodataka;
using Domain.Modeli;
using Domain.Repozitorijumi;

namespace Database.Repozitorijumi
{
    public class BiljkeRepozitorijum : IBiljkeRepozitorijum
    {
        private readonly IBazaPodataka _baza;

        public BiljkeRepozitorijum(IBazaPodataka baza)
        {
            _baza = baza;
        }


        //123commit
        public Biljka DodajBiljku(Biljka biljka)
        {
            biljka.Id = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            _baza.Tabele.Biljke.Add(biljka);
            _baza.SacuvajPromene();
            return biljka;
        }

        public IEnumerable<Biljka> SveBiljke()
        {
            return _baza.Tabele.Biljke;
        }
        public Biljka PronadjiPoNazivu(string naziv)
        {
            return _baza.Tabele.Biljke
                .FirstOrDefault(b => b.Naziv == naziv);
        }

        public void IzmeniJacinuArome(Biljka biljka, double novaJacina)
        {
            biljka.JacinaArome = novaJacina;
            _baza.SacuvajPromene();
        }

    }
}

