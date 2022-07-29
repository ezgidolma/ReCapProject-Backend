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
    public interface IUsersService
    {
        IResult Add(Users users );

        IResult Update(Users users);

        IResult Delete(Users users);
        IDataResult<List<Users>> GetAll();
        IDataResult<Users> GetById(int id);
        
    }
}
