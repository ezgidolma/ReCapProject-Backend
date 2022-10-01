
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        [CacheAspect]//key,value
        public IDataResult<List<Car>> GetAll()
        {
           
          return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);
        }
        public IDataResult<List<CarDetailDto>> GetAllByBrandId(int brandId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(p =>p.BrandId == brandId));
        }


        public IDataResult<List<CarDetailDto>> GetAllByColorId(int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(p => p.ColorId== colorId));
        }

        [SecuredOperation("car.add")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
            
        }

        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);

        }

        public IDataResult< List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>> (_carDal.GetCarDetails(),Messages.CarDetails);
        }

        [CacheAspect]
        [PerformanceAspect(5)]//metot çalışmayı 5 sn geçerse beni uyar
        public IDataResult< Car> GetById(int carId)
        {
            return new SuccessDataResult<Car> (_carDal.Get(p => p.Id == carId));
        }

        public IDataResult<List<CarDetailDto>> GetByCarId(int carId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.CarId == carId), Messages.CarListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarFilter(int colorId, int brandId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.ColorId == colorId && c.BrandId == brandId));
        }
    } 
}