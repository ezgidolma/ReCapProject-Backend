using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomersManager:ICustomersDal
    {
        ICustomersDal customersDal;
        public CustomersManager(ICustomersDal customersDal)
        {
            this.customersDal = customersDal;
        }

        public void Add(Customers entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customers entity)
        {
            throw new NotImplementedException();
        }

        public Customers Get(Expression<Func<Customers, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Customers> GetAll(Expression<Func<Customers, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Customers entity)
        {
            throw new NotImplementedException();
        }
    }
}
