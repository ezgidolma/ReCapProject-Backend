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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCapContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using var context = new ReCapContext();
            var result = from cus in context.Customers
                         join user in context.Users on cus.UserId equals user.Id
                         select new CustomerDetailDto
                         {
                             CustomerId = cus.UserId,
                             FirstName = user.FirstName,
                             LastName = user.LastName,
                             CompanyName = cus.CompanyName
                         };
            return result.ToList();
        }
    }
}
