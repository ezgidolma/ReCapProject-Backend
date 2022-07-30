using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User users );

        IResult Update(User users);

        IResult Delete(User users);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int id);
        
    }
}
