using System;
using Xunit;

namespace Vaa.Domain.Test
{
    public class WagenStoreTest
    {
        [Fact]
        public void LijstShouldReturnAListOfWagens()
        {
            var store = new WagenStore();

            Assert.Equal(store.Lijst().Count, 4);
        }

        [Fact]
        public void WagenShouldReturnASingleWagenIfFound()
        {
            var store = new WagenStore();
            var wagen1 = store.Data["ABC-123"];

            Assert.Equal(wagen1, store.Wagen("ABC-123"));
        }

        [Fact]
        public void WagenShouldThrowExceptionWhenNotFound()
        {
            var store = new WagenStore();

            Assert.Throws<Exception>(() => store.Wagen("WRONGNUM"));
        }

        [Fact]
        public void WagenVerwijderenHappyPath()
        {
            var store = new WagenStore();

            Assert.Equal(4, store.Data.Count);

            store.WagenVerwijderen("ABC-123");

            Assert.Equal(3, store.Data.Count);
        }

        [Fact]
        public void WagenVerwijderenShouldThrowException()
        {
            var store = new WagenStore();

            Assert.Throws<Exception>(() => store.WagenVerwijderen("SOMEBADHING"));
        }

        [Fact]
        public void WagenToevoegenShouldAddWagen()
        {
            var store = new WagenStore();
            var newWagen = new DieselWagen(120000.0m, 2014, "RTY-887", 101.0m);

            Assert.Equal(4, store.Data.Count);

            store.WagenToevoegen(newWagen);

            Assert.Equal(5, store.Data.Count);
        }

        [Fact]
        public void WagenToevoegenShouldThrowException()
        {
            var store = new WagenStore();
            var newWagen = new DieselWagen(12000.5m, 2013, "ABC-123", 102.1m);

            Assert.Equal(4, store.Data.Count);
            Assert.Throws<Exception>(() => store.WagenToevoegen(newWagen));
        }
    }
}
