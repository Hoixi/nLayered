using Business.Abstracts;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concrates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public async Task Add(User user)
        {
            await _userDal.AddAsync(user);
        }

        public async Task Delete(User user, bool perm)
        {
            await _userDal.DeleteAsync(user, perm);
        }

        public async Task<IPaginate<User>> Get(int Id)
        {
            return await _userDal.GetListAsync(i => i.Id == Id);
        }
    }
}
