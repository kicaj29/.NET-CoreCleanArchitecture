using AutoMapper;
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
        private readonly IMapper _autoMapper;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus, IMapper autoMapper)
        {
            this._courseRepository = courseRepository;
            this._bus = bus;
            this._autoMapper = autoMapper;
        }

        public void Create(CourseViewModel coursViewModel)
        {
            this._bus.SendCommandAsync(this._autoMapper.Map<CreateCoursCommand>(coursViewModel));
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
