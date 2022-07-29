using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
    public class CustomersManager:ICustomersService
    {
        ICustomersDal _customersDal;
        public CustomersManager(ICustomersDal customersDal)
        {
            _customersDal = customersDal;
        }
         
        public IResult Add(Customers customers)
        {
            _customersDal.Add(customers);
            return new SuccessResult(Messages.CustomersAdded);
        }

        public IResult Delete(Customers customers)
        {
            _customersDal.Delete(customers);
            return new SuccessResult(Messages.CustomerslDeleted);
        }

       

        public IDataResult<List<Customers>> GetAll()
        {
            return new SuccessDataResult<List<Customers>>(_customersDal.GetAll(), Messages.BrandsListed);
        }

        public IDataResult<Customers> GetById(int id)
        {
            return new SuccessDataResult<Customers>(_customersDal.Get(p => p.UserId == id));
        }

        public IResult Update(Customers customers)
        {
            _customersDal.Update(customers);
            return new SuccessResult(Messages.CustomersUpdated);
        }
    }
}
