using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomersService
    {
        IResult Add(Customers customers);

        IResult Update(Customers customers);

        IResult Delete(Customers customers);
        IDataResult<List<Customers>> GetAll();
        IDataResult<Customers> GetById(int id);
    }
}
