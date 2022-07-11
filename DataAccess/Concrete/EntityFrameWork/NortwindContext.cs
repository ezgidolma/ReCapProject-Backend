﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork
{
    //context Db tablolarıyla proje classlarını bağlama
    public class NortwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//bu metod senin hangi veritabanıyla çalıştığını söyler
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ReCap;Trusted_Connection=true");
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<Brand> Brands { get; set; }
    }
}
