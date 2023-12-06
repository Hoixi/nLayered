using Core.DataAccess.Paging;
using Entities.Concrates;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        Task<IPaginate<CourseCategoryDTO>> GetCourseCategoryName();
        Task Add(Course course);
        Task Delete(Course course,bool perm);
        Task<IPaginate<Course>> Get(int Id);
    }
}
