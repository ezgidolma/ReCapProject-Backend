using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UsersManager:IUsersService
    {
        IUsersDal _usersDal;
        public UsersManager(IUsersDal usersDal)
        {
           _usersDal = usersDal;
        }

        public IResult Add(Users users)
        {
            if (users.FirstName.Length > 1)
            {
                _usersDal.Add(users);
                return new SuccessResult(Messages.UsersAdded);

            }
            return new ErrorResult(Messages.UsersNameInvalid);
        }

        public IResult Delete(Users users)
        {
            _usersDal.Delete(users);
            return new SuccessResult(Messages.UsersDeleted);
        }

      
        public IDataResult<List<Users>> GetAll()
        {
            return new SuccessDataResult<List<Users>>(_usersDal.GetAll(), Messages.UsersListed);
        }

        public IDataResult<Users> GetById(int id)
        {
            return new SuccessDataResult<Users>(_usersDal.Get(p => p.Id == id));
        }

        

        public IResult Update(Users users)
        {
            _usersDal.Update(users);
            return new SuccessResult(Messages.UsersUpdated);
        }
    }
}
