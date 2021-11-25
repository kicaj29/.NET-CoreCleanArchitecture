using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Mvc.Configuration
{
    public static class AutoMapperConfiguration
    {
        public static void RegisterAutoMapper(this IServiceCollection service)
        {
            service.AddAutoMapper(typeof(CleanArch.Application.AutoMapper.AutoMapperConfiguration));
            Application.AutoMapper.AutoMapperConfiguration.RegisterMappings();
        }
    }
}
