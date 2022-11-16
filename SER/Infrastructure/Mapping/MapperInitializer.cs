using AutoMapper;
using SER.Domain.Models;
using SER.Infrastructure.ViewModel.DuAn;

namespace SER.Infrastructure.Mapping
{
    public class MapperInitializer:Profile
    {
        public MapperInitializer()
        {
            CreateMap<Duan, DuAnReponse>().ReverseMap();
            CreateMap<Duan, DuAnResquest>().ReverseMap();
        }
    }
}
