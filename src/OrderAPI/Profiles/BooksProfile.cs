﻿using AutoMapper;
using OrderAPI.Dtos;
using OrderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Profiles
{
    public class BooksProfile : Profile
    {
        public BooksProfile()
        {
            // Source -> Target
            // Books
            CreateMap<Book, BookReadDto>();
            CreateMap<BookCreateDto, Book>();
            CreateMap<BookUpdateDto, Book>();
            CreateMap<Book, BookUpdateDto>();
        }
    }
}
