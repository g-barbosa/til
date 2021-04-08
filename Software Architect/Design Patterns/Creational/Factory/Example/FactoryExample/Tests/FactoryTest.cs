using FactoryExample.ConcreteCreator;
using FactoryExample.Creator;
using FactoryExample.Product;
using System;
using Xunit;

namespace Tests
{
    public class FactoryTest
    {
        [Theory]
        [InlineData("Street", 7.75, 139, 31)]
        [InlineData("Vertical", 8.5, 149, 40)]
        [InlineData("MiniCruiser", 7, 129, 46)]
        public void ShouldReturnASkate(string type, double shapeSize, int truckSize, int wheelSize)
        {
            SkateFactory skateFactory = null;

            switch (type.ToLower())
            {
                case "street":
                    skateFactory = new StreetFactory(shapeSize, truckSize, wheelSize);
                    break;
                case "vertical":
                    skateFactory = new VerticalFactory(shapeSize, truckSize, wheelSize);
                    break;
                case "minicruiser":
                    skateFactory = new MiniCruiserFactory(shapeSize, truckSize, wheelSize);
                    break;
                default:
                    break;
            }

            Skate skate = skateFactory.SearchSkate();

            Assert.Equal(type.ToLower(), skate.Type.ToLower());
            Assert.Equal(shapeSize, skate.ShapeSize);
            Assert.Equal(truckSize, skate.TruckSize);
            Assert.Equal(wheelSize, skate.WheelSize);
        }
    }
}
