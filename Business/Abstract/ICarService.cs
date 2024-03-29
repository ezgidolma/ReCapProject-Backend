﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>>GetAll();
        IDataResult<List<CarDetailDto>> GetAllByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetAllByColorId(int colorId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();//uygulamalarda tutarlılığı korumak için yaptığımız bir yöntem

        IDataResult<List<CarDetailDto>> GetByCarId(int carId);

       
        IDataResult<List<CarDetailDto>> GetCarDetailsByColorAndByBrand(int colorId, int brandId);
       



    }
}
