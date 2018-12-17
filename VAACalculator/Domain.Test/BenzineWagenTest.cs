using System;
using Xunit;

namespace Vaa.Domain.Test
{
    public class BenzineWagenDieselTest
    {
        [Fact]
        public void BenzineWagenShouldHaveCorrectProperties()
        {
            var wagen = new BenzineWagen((decimal)12000.5,2007,"KGB-123",(decimal)99.2);

            Assert.Equal((decimal)12000.5, wagen.CatalogusPrijs);
            Assert.Equal(2007, wagen.Bouwjaar);
            Assert.Equal("KGB-123", wagen.Nummerplaat);
            Assert.Equal((decimal)99.2m, wagen.CO2);
        }

        [Fact]
        public void ToStringTest()
        {
            var wagen = new BenzineWagen((decimal)12000.5,2007,"KGB-123",(decimal)99.2);

            Assert.Equal("catalogus prijs: 12000.5, bouwjaar: 2007, nummerplaat: KGB-123, CO2: 99.2", wagen.ToString());
        }
    }
}
