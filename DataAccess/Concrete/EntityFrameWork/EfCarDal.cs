﻿using DataAccess.Abstract;
using Entities.Concrete;
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
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (NortwindContext context = new NortwindContext())
            {
                var addedEntitiy = context.Entry(entity);
                addedEntitiy.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (NortwindContext context = new NortwindContext())
            {
                var deletedEntitiy = context.Entry(entity);//refernası yakala
                deletedEntitiy.State = EntityState.Deleted;//ekle savechange ile olur
                context.SaveChanges();
            }


        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (NortwindContext context = new NortwindContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }

        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (NortwindContext context = new NortwindContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (NortwindContext context = new NortwindContext())
            {
                var updateedEntitiy = context.Entry(entity);
                updateedEntitiy.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

    }
}