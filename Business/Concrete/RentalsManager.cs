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
    public class RentalsManager:IRentalsService
    {
        IRentalsDal _rentalsDal;

        public RentalsManager(IRentalsDal rentalsDal)
        {
            _rentalsDal = rentalsDal;
        }

        public IResult Add(Rentals rentals)
        {
            if (rentals.ReturnDate < DateTime.Now || rentals.ReturnDate == null)
            {
                return new ErrorResult(Messages.RentalsNameInvalid);
            }
            _rentalsDal.Add(rentals);
            return new SuccessResult(Messages.RentalsAdded);
        }

        public IResult Delete(Rentals rentals)
        {
           _rentalsDal.Delete(rentals);
            return new SuccessResult(Messages.RentaslDeleted);
        }


        
        public IDataResult<List<Rentals>> GetAll()
        {
            return new SuccessDataResult<List<Rentals>>(_rentalsDal.GetAll(), Messages.BrandsListed);
        }

        public IDataResult<Rentals> GetById(int id)
        {
            return new SuccessDataResult<Rentals>(_rentalsDal.Get(p => p.Id == id));
        }

        public IResult Update(Rentals rentals)
        {
            _rentalsDal.Update(rentals);
            return new SuccessResult(Messages.RentalsUpdated);
        }
    }
}
