using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concrates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class EfUserDal : EfRepositoryBase<User, int, NorthwindContext>, IUserDal
{
    public EfUserDal(NorthwindContext context) : base(context)
    {
    }
}
