using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Modeli;
using Domain.Repozitorijumi;
using Domain.Servisi;

namespace Services.BiljkeServisi
{
    public class BiljkeServis : IBiljkeServis
    {
        private readonly IBiljkeRepozitorijum _repo;

        public BiljkeServis(IBiljkeRepozitorijum repo)
        {
            _repo = repo;
        }

        public Biljka ZasadiBiljku(string naziv, double kolicina, double jacinaArome)
        {
            Biljka biljka = new Biljka(naziv, kolicina, jacinaArome);
            return _repo.DodajBiljku(biljka);
        }

        public bool IzmeniJacinuArome(string nazivBiljke, double novaJacina)
        {
            Biljka biljka = _repo.PronadjiPoNazivu(nazivBiljke);

            if (biljka == null)
                return false;

            _repo.IzmeniJacinuArome(biljka, novaJacina);
            return true;
        }

    }
}
