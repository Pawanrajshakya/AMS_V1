using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service_Layer.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //Group
            CreateMap<Persistence_Layer.Models.Group, Service_Layer.DTOs.GroupDto>();
            CreateMap<Service_Layer.DTOs.GroupDto, Persistence_Layer.Models.Group>();
            CreateMap<Service_Layer.DTOs.GroupToEditDto, Persistence_Layer.Models.Group>();
            CreateMap<Service_Layer.DTOs.GroupToSaveDto, Persistence_Layer.Models.Group>();
        }
    }
}
