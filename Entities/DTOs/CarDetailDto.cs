﻿using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    //Joinler buarada olacak 
    public class CarDetailDto : IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }

        public string BrandName { get; set; }

        public int BrandId { get; set; }

        public int ColorId { get; set; }
        public string ColorName { get; set; }

        public int DailyPrice { get; set; }

        public int ModelYear { get; set; }

        public string ImagePath { get; set; }

    }
}
