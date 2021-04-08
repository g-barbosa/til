using FactoryExample.ConcreteProduct;
using FactoryExample.Creator;
using FactoryExample.Product;

namespace FactoryExample.ConcreteCreator
{
    public class StreetFactory : SkateFactory
    {
        private double _shapeSize;
        private int _truckSize;
        private int _wheelSize;

        public StreetFactory(double shapeSize, int truckSize, int wheelSize)
        {
            _shapeSize = shapeSize;
            _wheelSize = wheelSize;
            _truckSize = truckSize;
        }

        public override Skate SearchSkate()
        {
            return new StreetSkate(_wheelSize, _shapeSize, _truckSize);
        }
    }
}
