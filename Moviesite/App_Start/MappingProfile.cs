using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Moviesite.DTOs;
using Moviesite.Models;

namespace Moviesite.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDTO>();
            Mapper.CreateMap<CustomerDTO, Customer>();
        }
    }
}