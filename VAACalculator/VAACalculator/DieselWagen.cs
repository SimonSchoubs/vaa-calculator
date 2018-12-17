using System;
using System.Text.RegularExpressions;

namespace VAACalculator
{
    public class DieselWagen : Wagen
    {
        public decimal NOx { get; set; }

        public DieselWagen(string prijs, string jaar, string nummerplaat, string nox)
        {
            if (prijs == null || prijs == "" || !decimal.TryParse(prijs, out decimal parsedPrijs))
            {
                throw new Exception("Prijs moet een correcte waarde hebben!");
            }
            if (jaar == null || jaar == "" || !int.TryParse(jaar, out int parsedJaar))
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
            if (nox == null || nox == "" || !decimal.TryParse(nox, out decimal parsedNox))
            {
                throw new Exception("NOx moet een correcte waarde hebben!");
            }
            CatalogusPrijs = parsedPrijs;
            Bouwjaar = parsedJaar;
            Nummerplaat = nummerplaat;
            NOx = parsedNox;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(",   NOx: {0}", NOx);
        }

        public override decimal VAA()
        {
            return CatalogusPrijs * NOx / 1000;
        }
    }
}
