using System;
using System.Collections.Generic;

namespace Vaa.Domain
{
    public class WagenStore
    {
        public Dictionary<string, Wagen> Data { get; private set; }

        public WagenStore()
        {
            Data = new Dictionary<string, Wagen>();
            Data.Add("ABC-123", new DieselWagen(10000.0m, 2009, "ABC-123", 99.9m));
            Data.Add("ABC-456", new DieselWagen(12000.0m, 2007, "ABC-456", 99.9m));
            Data.Add("GHJ-123", new DieselWagen(14000.0m, 2010, "GHJ-123", 99.9m));
            Data.Add("GHJ-633", new DieselWagen(16000.0m, 2012, "GHJ-633", 99.9m));
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
    }
}
