using System;
using System.Linq;
using AutoMapper;
using HiQo.StaffManagement.Core.Models;

namespace HiQo.StaffManagement.Configuration.AutoMapper
{
    public class AutoMappingConfig
    {
        public static void ConfigureAutoMapping()
        {
            Mapper.Initialize(GetConfiguration);
        }

        private static void GetConfiguration(IMapperConfigurationExpression configuration)
        {
            var profiles = typeof(AutoMappingConfig).Assembly.GetTypes().Where(x => typeof(Profile).IsAssignableFrom(x));

            foreach (var profile in profiles)
            {
                configuration.AddProfile(Activator.CreateInstance(profile) as Profile);
            }
        }
    }
}
