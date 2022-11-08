using AutoMapper;
using DemoGeneric.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoGeneric.Infrastructure.ViewModel.Category;
using DemoGeneric.Infrastructure.ViewModel.Product;
using DemoGeneric.Infrastructure.ViewModel.Detail;

namespace DemoGeneric.Domain.Extensions
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
