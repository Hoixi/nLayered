using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
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

        public async Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest)
        {
            Course course = new Course();
            course.Id = Guid.NewGuid();
            course.Name =createCourseRequest.Name;
            course.Description =createCourseRequest.Description;
            course.categoryId = createCourseRequest.categoryId;
            course.UserId = createCourseRequest.UserId;
            course.ImgPath= createCourseRequest.ImgPath;


            Course CreatedCourse =  await _courseDal.AddAsync(course);

            CreatedCourseResponse createdCourseResponse = new CreatedCourseResponse();
            createdCourseResponse.Id = CreatedCourse.Id;
            createdCourseResponse.Name = createCourseRequest.Name;
            createdCourseResponse.Description = createCourseRequest.Description;
            createdCourseResponse.categoryId = createCourseRequest.categoryId;
            createdCourseResponse.UserId = createCourseRequest.UserId;
            createdCourseResponse.ImgPath = createCourseRequest.ImgPath;

            return createdCourseResponse;

        }
       
        public async Task Update(Course course)
        {
            await _courseDal.UpdateAsync(course);
        }
       
        public async Task Delete(Course course,bool perm)
        {
           await _courseDal.DeleteAsync(course,perm);           
        }

        public async Task<IPaginate<Course>> Get(Guid Id)
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
