
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
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

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araba başarıyla silindi");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            var result = _carDal.Get(p => p.Id == brandId);
            return result;
        }

        public List<Car> GetAllByColorId(int colorId)
        {
            var result = _carDal.Get(p => p.Id == colorId);
            return result;
        }

        public Car GetById(int carId)
        {
            
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
            Console.WriteLine("Araba başarıyla eklendi.");
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Araba başarıyla güncellendi.");
        }
    } 
}
