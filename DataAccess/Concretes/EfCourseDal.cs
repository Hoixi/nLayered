using Core.DataAccess.Paging;
using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concrates;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfCourseDal : EfRepositoryBase<Course, int, NorthwindContext>, ICourseDal
    {
        NorthwindContext _context;
        public EfCourseDal(NorthwindContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IPaginate<CourseCategoryDTO>> CourseCategory()
        {
            var result = await (from course in _context.Courses
                          join category in _context.Categories
                          on course.categoryId equals category.Id
                          select new CourseCategoryDTO
                          {
                              categoryName = category.Name,
                              courseName = course.Name,
                          }).ToPaginateAsync(0, 20, 0);
            return result;
        }
    }
}
