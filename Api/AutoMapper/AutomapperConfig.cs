using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.AutoMapper
{
    public class AutomapperConfig
    {

        public MapperConfiguration Configure()
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DomainToViewModelMappingProfile>();
                cfg.AddProfile<ViewModelToDomainMappingProfile>();
            });
            return config;

        }
    }
}