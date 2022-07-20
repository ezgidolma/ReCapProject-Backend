using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2008,DailyPrice=900,Description="Clio"},
                new Car{Id=2,BrandId=1,ColorId=2,ModelYear=2012,DailyPrice=900,Description="Mini Cooper"},
                new Car{Id=3,BrandId=1,ColorId=1,ModelYear=2020,DailyPrice=1000,Description="Passat"},
                new Car{Id=4,BrandId=1,ColorId=3,ModelYear=2006,DailyPrice=1200,Description="BMW"},
                new Car{Id=5,BrandId=1,ColorId=4,ModelYear=2005,DailyPrice=200,Description="Broadway"},

            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car  carToDelete = _cars.SingleOrDefault(p=>p.Id==car.Id);
            _cars.Remove(carToDelete);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
           return _cars.Where(p=>p.Id==Id).ToList();

        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id=car.Id;
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.Description=car.Description;    

        }
    }
}
