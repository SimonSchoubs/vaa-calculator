using System;

namespace Vaa.Domain
{
    public class BenzineWagen : Wagen
    {
        public decimal CO2 { get; set; }

        public BenzineWagen(decimal prijs, int jaar, string nummerplaat, decimal co2)
        {
            CatalogusPrijs = prijs;
            Bouwjaar = jaar;
            Nummerplaat = nummerplaat;
            CO2 = co2;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(", CO2: {0}", CO2);
        }

        public override decimal VAA()
        {
            return CatalogusPrijs * CO2 / 1000;
        }
    }
}
