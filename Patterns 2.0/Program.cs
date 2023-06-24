using Patterns_2._0.Machines;

namespace Patterns_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            CarPlant plant = new CarPlant();
            
            Conveyor moto = new Moto();
            plant.Construct(moto);
            moto.Product.Show();

            Conveyor car = new Car();
            plant.Construct(car);
            car.Product.Show();

            Conveyor skut = new Skut();
            plant.Construct(skut);
            skut.Product.Show();
        }
    }
}