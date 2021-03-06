using System;
using System.Collections.Generic;

namespace VAACalculator
{
    public class WagenStore
    {
        public Dictionary<string, Wagen> Data { get; private set; }

        public WagenStore()
        {
            Data = new Dictionary<string, Wagen>();
            try
            {
                Data.Add("ABC-123", new DieselWagen("10000", "2009", "ABC-123", "100"));
                Data.Add("ABC-456", new DieselWagen("12000", "2007", "ABC-456", "100"));
                Data.Add("GHJ-123", new BenzineWagen("14000", "2010", "GHJ-123", "100"));
                Data.Add("GHJ-633", new DieselWagen("16000", "2012", "GHJ-633", "100"));
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            
        }

        public List<Wagen> Lijst()
        {
            var wagenlist = new List<Wagen>(Data.Values);
            return wagenlist;
        }

        public Wagen Wagen(string nummerplaat)
        {
            if (!Data.ContainsKey(nummerplaat))
            {
                throw new Exception("Wagen met deze nummerplaat bestaat niet!");
            }
            else
            {
                return Data[nummerplaat];
            }
        }

        public void WagenToevoegen(Wagen wagen)
        {
            if (Data.ContainsKey(wagen.Nummerplaat))
            {
                throw new Exception("Nummerplaat moet uniek zijn!");
            }
            else
            {
                Data.Add(wagen.Nummerplaat, wagen);
            }
        }

        public void WagenVerwijderen(string nummerplaat)
        {
            if (!Data.ContainsKey(nummerplaat))
            {
                throw new Exception("Wagen met deze nummerplaat bestaat niet!");
            }
            else
            {
                Data.Remove(nummerplaat);
            }
        }

        public decimal VAATotaal()
        {
            decimal totaal = 0.0m;

            foreach (var wagen in Data.Values)
            {
                totaal += wagen.VAA();
            }
            return totaal;
        }
    }
}
