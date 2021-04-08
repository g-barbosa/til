
namespace FactoryExample.Product
{
    public abstract class Skate
    {
        public abstract string Type { get; }
        public abstract int WheelSize { get; set; }
        public abstract double ShapeSize { get; set; }
        public abstract int TruckSize { get; set; }
    }
}
