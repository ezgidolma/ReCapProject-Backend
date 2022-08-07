using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{

    public class CarImageManager : ICarImageService
    {
        public IResult Add(IFormFile formFile, CarImage carImage)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(CarImage carImage)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarImage> GetByCarImageId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetCarImagesByCarId(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(IFormFile formFile, CarImage carImage)
        {
            throw new NotImplementedException();
        }
    }
}
