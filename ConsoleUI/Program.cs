using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main()
        {

            //CarAdded();
            //CarTest();
            //ColorAdded();
            //ColorTest();
            //UserAdded();

            //CustomerAdd();
            /*
            Rentals rental = new Rentals
            {
                CarId = 2,
                CustomerId = 1,
                RentDate = new DateTime(2022, 08, 16),
                ReturnDate = new DateTime(2002, 09, 25)
            };
            RentalsManager rentalManager = new RentalsManager(new EfRentalsDal());
            Console.WriteLine(rentalManager.Add(rental).Message);
            */

            Users users = new Users
            {
                Id = 12,
                Email = "ezgidolma@hotmil.vom",
                FirstName = "ezgi",
                LastName = "dolma",
                Password = 13

            };
            UsersManager usersManager = new UsersManager(new EfUsersDal());
            Console.WriteLine(usersManager.Add(users).Message);

        }
        private static void CarAdded()
        {
            Car car = new Car()
            {
                Id = 5,
                BrandId = 2,
                ModelYear = 1923,
                ColorId = 1,
                DailyPrice = 120,
                Description = "Temiz ve boyasız"
            }; 

         }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetAll().Data)
            {
                Console.WriteLine(item.Description);
            }
        }

        private static void ColorAdded()
        {
            Color color = new Color()
            {
                Id = 9,
                Name="Mercan"
                
            };

        }
        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var item in colorManager.GetAll().Data)
            {
                Console.WriteLine(item.Name);
            }
        }

        public static void UserAdded()
        {
            Users users = new Users()
            {
                FirstName = "Ezgi",
                LastName = "Dolma",
                Id = 1,
                Email="ezgidolma@gmail.com",
                Password=1234

            };
            UsersManager usersManager = new UsersManager(new EfUsersDal());
            usersManager.Add(users);
            foreach (var item in usersManager.GetAll().Data)
            {
                Console.WriteLine(item.FirstName);
            }

        }

    }

}
    
