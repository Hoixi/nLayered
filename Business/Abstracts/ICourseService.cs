using Business.Dtos.Requests;
using Business.Dtos.Responses;
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
        Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest);
        Task Update(Course course);
        Task Delete(Course course,bool perm);
        Task<IPaginate<Course>> Get(Guid Id);
    }
}
