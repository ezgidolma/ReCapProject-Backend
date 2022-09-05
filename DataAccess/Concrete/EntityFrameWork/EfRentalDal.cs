using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
      
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (var context = new ReCapContext())
            {
                var result = from rental in context.Rentals
                             join customer in context.Customers on rental.CustomerId equals customer.UserId
                             join car in context.Cars on rental.CarId equals car.Id
                             join user in context.Users on customer.UserId equals user.Id
                             join brand in context.Brands on car.BrandId equals brand.Id
                             select new RentalDetailDto
                             {
                                 CarName=car.Description,
                                 RentalId = rental.Id,
                                 BrandName = brand.Name,
                                 CustomerName = user.FirstName + " " + user.LastName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
