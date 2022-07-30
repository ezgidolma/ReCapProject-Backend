using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Keyless]
    public class Customer:IEntity
    {
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
