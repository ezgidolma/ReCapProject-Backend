using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main()
        {
            
        }

        private static void GetByColor(CarManager carManager)
        {
            Console.WriteLine("\nColor id 1:");
            foreach (var car in carManager.GetAllByColorId(1).Data)
            {
                Console.WriteLine("{0}\t {1} \t {2}", car.Id, car.ModelYear, car.Description);
            }
        }

        private static void GetByBrand(CarManager carManager)
        {
            Console.WriteLine("\nBrand id 3:");
            foreach (var car in carManager.GetAllByBrandId(3).Data)
            {
                Console.WriteLine("{0}\t {1} \t {2}", car.Id, car.ModelYear, car.Description);
            }
        }
    }
}