using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Modeli;

namespace Domain.Repozitorijumi
{
    public interface IBiljkeRepozitorijum
    {
        Biljka DodajBiljku(Biljka biljka);
        IEnumerable<Biljka> SveBiljke();

        Biljka PronadjiPoNazivu(string naziv);
        void IzmeniJacinuArome(Biljka biljka, double novaJacina);

    }
}
