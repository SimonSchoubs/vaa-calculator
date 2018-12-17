using System;

namespace Vaa.Domain
{
    public abstract class Wagen
    {
        public decimal CatalogusPrijs { get; set; }
        public int Bouwjaar { get; set; }
        public string Nummerplaat { get; set; }

        public override string ToString()
        {
            return String.Format("catalogus prijs: {0}, bouwjaar: {1}, nummerplaat: {2}", CatalogusPrijs, Bouwjaar, Nummerplaat);
        }

        public abstract decimal VAA();
    }
}
