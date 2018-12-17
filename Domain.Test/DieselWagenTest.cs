using System;
using Xunit;

namespace Vaa.Domain.Test
{
    public class WagenDieselTest
    {
        [Fact]
        public void DieselWagenShouldHaveCorrectProperties()
        {
            var wagen = new DieselWagen((decimal)12000.5,2007,"KGB-123",(decimal)99.2);

            Assert.Equal((decimal)12000.5, wagen.CatalogusPrijs);
            Assert.Equal(2007, wagen.Bouwjaar);
            Assert.Equal("KGB-123", wagen.Nummerplaat);
            Assert.Equal((decimal)99.2m, wagen.NOx);
        }

        [Fact]
        public void ToStringTest()
        {
            var wagen = new DieselWagen((decimal)12000.5,2007,"KGB-123",(decimal)99.2);
            Assert.Equal("catalogus prijs: 12000.5, bouwjaar: 2007, nummerplaat: KGB-123, NOx: 99.2", wagen.ToString());
        }
    }
}
