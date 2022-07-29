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
    public class RentalsManager:IRentalsDal
    {
        IRentalsDal _rentalsDal;

        public RentalsManager(IRentalsDal rentalsDal)
        {
            _rentalsDal = rentalsDal;
        }

        public void Add(Rentals entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Rentals entity)
        {
            throw new NotImplementedException();
        }

        public Rentals Get(Expression<Func<Rentals, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Rentals> GetAll(Expression<Func<Rentals, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Rentals entity)
        {
            throw new NotImplementedException();
        }
    }
}
