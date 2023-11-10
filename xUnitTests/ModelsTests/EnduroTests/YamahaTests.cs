﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehEvalu8.Models.Enduro;
using VehEvalu8.Models.Interfaces;
using Xunit;
using xUnitTests.ModelsTests.Interfaces;

namespace xUnitTests.ModelsTests.EnduroTests
{
    public class YamahaTests : IModelsTests
    {
        [Fact]
        public void ModelsShouldInitializeCorrectly()
        {
            string model = "WR-F";
            int cc = 250;
            int year = 2023;
            double priceForeign = 45000;
            string link = "www.yamaha.com";
            int distance = 25;

            var testYamaha = new Yamaha(cc, year, priceForeign, link, distance);

            Assert.Equal("Yamaha", testYamaha.Make);
            Assert.Equal(model, testYamaha.Model);
            Assert.Equal(cc, testYamaha.CC);
            Assert.Equal(year, testYamaha.Year);
            Assert.Equal(priceForeign, testYamaha.PriceForeign);
            Assert.Equal(link, testYamaha.Link);
            Assert.Equal(distance, testYamaha.DistanceToPickUp);
        }

        public void GetExpectedMarketPrice()
        {
            throw new NotImplementedException();
        }

        public void ModelsPropertiesMustHaveCorrectValues()
        {
            throw new NotImplementedException();
        }

        //TODO - LIST OF PRICES
    }
}

