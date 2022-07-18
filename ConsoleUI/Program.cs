using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using System;

namespace ConsoleUI {
    class Program
    {
        static void Main()
        {
            // CarTest();

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);

            }

             static void CarTest()
            {
                CarManager carManager = new CarManager(new EfCarDal());
                foreach (var car in carManager.GetAll())
                {
                    Console.WriteLine(car.Description);
                }
            }
        }
    }
}