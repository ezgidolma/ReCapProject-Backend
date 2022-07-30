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



            UserManager userManager = new UserManager(new EfUserDal());
            
            ListUsers(userManager);
            //AddCustomers(customerManager);
            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //AddRentals(rentalManager);
            //ListRentals(rentalManager);


        }

        private static void ListRentals(RentalManager rentalManager)
        {
            var rentals = rentalManager.GetAll();
            foreach (var rental in rentals.Data)
            {
                Console.WriteLine("Id: {0}, CarId: {1}, CustomerId: {2}, RentDate{3}, ReturnDate{4}", rental.Id, rental.CarId, rental.CustomerId, rental.RentDate, rental.ReturnDate);
            }
        }
        private static void ListCustomers(CustomerManager customerManager)
        {
            var customer = customerManager.GetAll();
            foreach (var rental in customer.Data)
            {
                Console.WriteLine("UserId: {0}, CompanyName: {1}",rental.UserId,rental.CompanyName);
            }
        }
        private static void ListUsers(UserManager userManager)
        {
            var rentals = userManager.GetAll();
            foreach (var rental in rentals.Data)
            {
                Console.WriteLine("Id: {0}, Email: {1}, Password: {2}, FirstName{3}, LastName{4}",rental.Id,rental.Email,rental.Password,rental.FirstName,rental.LastName);
            }
        }
        private static void AddUsers(UserManager userManager)
        {
            User user1 = new User { Id = 1, FirstName = "FirstName1", LastName = "LastName1", Email = "email1@email1.com", Password = 1 };
            User user2 = new User { Id = 2, FirstName = "FirstName2", LastName = "LastName2", Email = "email2@email2.com", Password = 2 };
            User user3 = new User { Id = 3, FirstName = "FirstName3", LastName = "LastName3", Email = "email3@email3.com", Password =22 };

            userManager.Add(user1);
            userManager.Add(user2);
            userManager.Add(user3);
        }
        private static void AddCustomers(CustomerManager customerManager)
        {
            Customer customer1 = new Customer { UserId = 1, CompanyName = "CompanyName1" };
            Customer customer2 = new Customer { UserId = 2, CompanyName = "CompanyName1" };
            Customer customer3 = new Customer { UserId = 3, CompanyName = "CompanyName2" };

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
        }
    }
        }

 
