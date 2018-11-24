using AutoMapper;
using lab7.ModelsForMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab7.Mapper
{
    public class MapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Customer, CustomerDto>()
                .ForMember(x=>x.FullName , conf=> conf.MapFrom(z=>z.Name+" " +z.Surname));
            }).CreateMapper(); 
        
    }
}
