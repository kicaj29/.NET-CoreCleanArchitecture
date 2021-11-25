using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            this._courseRepository = courseRepository;
            this._bus = bus;
        }

        public void Create(CourseViewModel coursViewModel)
        {
            var createCourseCommand = new CreateCoursCommand(coursViewModel.Name,
                coursViewModel.Description, coursViewModel.ImageUrl);

            this._bus.SendCommandAsync(createCourseCommand);
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = this._courseRepository.GetCourses()
            };
        }
    }
}
