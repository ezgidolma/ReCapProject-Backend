using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using System;

namespace ConsoleUI {
    class Program
    {
        static void Main()
        {
            CarTest();

            //BrandTest();

            static void CarTest()
            {
                CarManager carManager = new CarManager(new EfCarDal());
                foreach (var car in carManager.GetCarDetails())
                {
                    Console.WriteLine(car.CarName+ "/" +car.BrandName+"/"+car.CarId+"/"+car.ColorName);
                }
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);

            }
        }
    }
}