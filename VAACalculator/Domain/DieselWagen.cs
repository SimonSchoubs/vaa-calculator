using System;

namespace Vaa.Domain
{
    public class DieselWagen : Wagen
    {
        public decimal NOx { get; set; }

        public DieselWagen(decimal prijs, int jaar, string nummerplaat, decimal nox)
        {
            CatalogusPrijs = prijs;
            Bouwjaar = jaar;
            Nummerplaat = nummerplaat;
            NOx = nox;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(", NOx: {0}", NOx);
        }

        public override decimal VAA()
        {
            return CatalogusPrijs * NOx / 1000;
        }
    }
}
