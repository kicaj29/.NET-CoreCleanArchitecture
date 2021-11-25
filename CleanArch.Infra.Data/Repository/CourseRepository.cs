using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _dbContext;

        public CourseRepository(UniversityDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void Add(Course course)
        {
            this._dbContext.Courses.Add(course);
            this._dbContext.SaveChanges();
        }

        public IQueryable<Course> GetCourses()
        {
            return this._dbContext.Courses;
        }
    }
}
