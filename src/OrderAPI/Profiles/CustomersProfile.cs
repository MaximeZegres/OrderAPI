using AutoMapper;
using OrderAPI.Dtos;
using OrderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Profiles
{
    public class CustomersProfile : Profile
    {
        public CustomersProfile()
        {
            // Customers
            CreateMap<Customer, CustomerReadDto>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FirstName + ' ' + src.LastName));

            CreateMap<CustomerCreateDto, Customer>();
            CreateMap<CustomerUpdateDto, Customer>();
            CreateMap<Customer, CustomerUpdateDto>();
        }
        
        
    }
}
