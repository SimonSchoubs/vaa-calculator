using System;
using System.Text.RegularExpressions;

namespace VAACalculator
{
    public class BenzineWagen : Wagen
    {
        public decimal CO2 { get; set; }

        public BenzineWagen(string prijs, string jaar, string nummerplaat, string co2)
        {
            if (prijs == null || prijs == "" || prijs == "0" || !decimal.TryParse(prijs, out var parsedPrijs))
            {
                throw new Exception("Prijs moet een correcte waarde hebben!");
            }
            if (jaar == null || jaar == "" || !int.TryParse(jaar, out var parsedJaar) || parsedJaar < 1900 || parsedJaar > DateTime.Now.Year)
            {
                throw new Exception("Jaar moet een correcte waarde hebben!");
            }
            if (nummerplaat == null || nummerplaat == "")
            {
                throw new Exception("Nummerplaat mag niet leeg zijn!");
            }
            if (!Regex.IsMatch(nummerplaat, "^[A-Z]{3}-[0-9]{3}$"))
            {
                throw new Exception("Nummerplaat vorm is niet juist!");
            }
            if (co2 == null || co2 == "" || !decimal.TryParse(co2, out var parsedCo2) || !(parsedCo2 > 0))
            {
                throw new Exception("CO2 moet een correcte waarde hebben!");
            }
            CatalogusPrijs = parsedPrijs;
            Bouwjaar = parsedJaar;
            Nummerplaat = nummerplaat;
            CO2 = parsedCo2;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(",   CO2: {0}", CO2);
        }

        public override decimal VAA()
        {
            return CatalogusPrijs * CO2 / 1000;
        }
    }
}
