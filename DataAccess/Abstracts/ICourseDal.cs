using Core.DataAccess.Paging;
using Core.DataAccess.Repositories;
using Entities.Concrates;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICourseDal:IRepository<Course,int>,IAsyncRepository<Course, int>
    {
        Task<IPaginate<CourseCategoryDTO>> CourseCategory();
    }
}
