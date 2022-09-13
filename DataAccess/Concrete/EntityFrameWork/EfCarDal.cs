using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork
{
    //NuGet
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
       

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from ca in context.Cars
                             join b in context.Brands
                             on ca.BrandId equals b.BrandId
                             join co in context.Colors
                             on ca.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 CarId = ca.Id,
                                 BrandName = b.Name,
                                 DailyPrice = ca.DailyPrice,
                                 CarName = ca.Description,
                                 ModelYear=ca.ModelYear,
                                 BrandId=b.BrandId,
                                 ColorId=co.ColorId,
                                 ColorName = co.Name,
                                 ImagePath = (from img in context.CarImages
                                              where img.CarId == ca.Id
                                              select img.ImagePath).FirstOrDefault()

                             };

                return filter != null ? result.Where(filter).ToList() : result.ToList();

            }
        }
    }
}