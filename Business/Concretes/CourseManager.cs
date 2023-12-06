using Business.Abstracts;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concrates;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public async Task Add(Course course)
        {
            await _courseDal.AddAsync(course);
        }
       
        public async Task Delete(Course course,bool perm)
        {
           await _courseDal.DeleteAsync(course,perm);           
        }

        public async Task<IPaginate<Course>> Get(int Id)
        {
            return await _courseDal.GetListAsync(i => i.Id == Id);           
        }

        public async Task<IPaginate<CourseCategoryDTO>> GetCourseCategoryName()
        {
            var result = await _courseDal.CourseCategory();
            return result;
        }
    }
}
