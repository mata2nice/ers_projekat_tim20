using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Servisi;

namespace Presentation.Meni
{
    public class BiljkeMeni
    {
        private readonly IBiljkeServis _biljkeServis;

        public BiljkeMeni(IBiljkeServis biljkeServis)
        {
            _biljkeServis = biljkeServis;
        }

        public void Zasadi()
        {
            Console.Write("Naziv biljke: ");
            string naziv = Console.ReadLine();

            Console.Write("Kolicina: ");
            double kolicina = double.Parse(Console.ReadLine());

            Console.Write("Jacina arome (0-100): ");
            double jacina = double.Parse(Console.ReadLine());

            _biljkeServis.ZasadiBiljku(naziv, kolicina, jacina);

            Console.WriteLine("Biljka je uspesno zasadjenja.");
        }

        public void IzmeniJacinuArome()
        {
            Console.Write("Naziv biljke: ");
            string naziv = Console.ReadLine();

            Console.Write("Nova jacina arome (0-100): ");
            double novaJacina = double.Parse(Console.ReadLine());

            bool uspesno = _biljkeServis.IzmeniJacinuArome(naziv, novaJacina);

            if (uspesno)
                Console.WriteLine("Jacina arome je uspesno izmenjena.");
            else
                Console.WriteLine("Biljka sa tim nazivom ne postoji.");
        }

    }
}

