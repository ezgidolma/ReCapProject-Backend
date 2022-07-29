using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UsersManager:IUsersDal
    {
        IUsersDal usersDal;
        public UsersManager(IUsersDal usersDal)
        {
            this.usersDal = usersDal;
        }

        public void Add(Users entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Users entity)
        {
            throw new NotImplementedException();
        }

        public Users Get(Expression<Func<Users, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Users> GetAll(Expression<Func<Users, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Users entity)
        {
            throw new NotImplementedException();
        }
    }
}
