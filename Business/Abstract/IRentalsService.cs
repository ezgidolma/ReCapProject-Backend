using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalsService
    {
        IResult Add(Rentals rentals);

        IResult Update(Rentals rentals);

        IResult Delete(Rentals rentals);
        IDataResult<List<Rentals>> GetAll();
        IDataResult<Rentals> GetById(int id);
    }
}
