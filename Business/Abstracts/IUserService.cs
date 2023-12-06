using Core.DataAccess.Paging;
using Entities.Concrates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserService
    {
        Task Add(User user);
        Task Delete(User user, bool perm);
        Task<IPaginate<User>> Get(int Id);
    }
}
