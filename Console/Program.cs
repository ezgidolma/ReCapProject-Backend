
using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace Console
{
    class Program
    {
        static void Main()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Description);
            }
        }
    }
}