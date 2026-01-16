using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Modeli;

namespace Domain.Servisi
{
    public interface IBiljkeServis
    {
        Biljka ZasadiBiljku(string naziv, double kolicina, double jacinaArome);
        bool IzmeniJacinuArome(string nazivBiljke, double novaJacina);

    }
}
