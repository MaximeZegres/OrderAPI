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
            CreateMap<Customer, CustomerReadDto>();
            CreateMap<CustomerCreateDto, Customer>();
            CreateMap<CustomerUpdateDto, Customer>();
            CreateMap<Customer, CustomerUpdateDto>();
        }
        
        
    }
}
