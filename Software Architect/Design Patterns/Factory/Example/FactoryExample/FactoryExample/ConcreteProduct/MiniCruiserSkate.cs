using FactoryExample.Product;

namespace FactoryExample.ConcreteProduct
{
    public class MiniCruiserSkate : Skate
    {
        private readonly string _type;
        private int _wheelSize;
        private double _shapeSize;
        private int _truckSize;
        public MiniCruiserSkate(int wheelSize, double shapeSize, int truckSize)
        {
            _type = "MiniCruiser";
            _shapeSize = shapeSize;
            _wheelSize = wheelSize;
            _truckSize = truckSize;
        }

        public override string Type
        {
            get { return _type; }
        }
        public override int WheelSize
        {
            get { return _wheelSize; }
            set { _wheelSize = value; }
        }
        public override double ShapeSize
        {
            get { return _shapeSize; }
            set { _shapeSize = value; }
        }
        public override int TruckSize
        {
            get { return _truckSize; }
            set { _truckSize = value; }
        }
    }
}
