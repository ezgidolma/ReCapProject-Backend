using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
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
    public class RentalManager:IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalsDal)
        {
            _rentalDal = rentalsDal;
        }

        public IResult Add(Rental rental)
        {
            ValidationTool.Validate(new RentalValidator(), rental);

            _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
            
        }

        public IResult Delete(Rental rental)
        {
           _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentaslDeleted);
        }


        
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.BrandsListed);
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.Id == id));
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalsUpdated);
        }
    }
}
