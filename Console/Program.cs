
using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using DataAccess.Concrete.InMemory;

namespace Console
{
    class Program
    {
        static void Main()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                System.Console.WriteLine(car.Description);
            }
        }
    }
}