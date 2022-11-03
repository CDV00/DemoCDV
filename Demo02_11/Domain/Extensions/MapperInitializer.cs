using AutoMapper;
using Demo02_11.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo02_11.Infrastructure.ViewModel.Category;
using Demo02_11.Infrastructure.ViewModel.Product;
using Demo02_11.Infrastructure.ViewModel.Detail;

namespace Demo02_11.Domain.Extensions
{
    public class MapperInitializer:Profile
    {
        public MapperInitializer()
        {
            CreateMap<Category, CategoryReponse>().ReverseMap();
            CreateMap<Category, CategoryResquest>().ReverseMap();
            CreateMap<Product, ProductReponse>().ReverseMap();
            CreateMap<Product, ProductResquest>().ReverseMap();
            CreateMap<Detail, DetailReponse>().ReverseMap();
            CreateMap<Detail, DetailResquest>().ReverseMap();
        }
    }
}
