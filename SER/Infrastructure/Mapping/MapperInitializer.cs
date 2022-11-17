using AutoMapper;
using SER.Domain.Models;
using SER.Infrastructure.ViewModel.DuAn;
using SER.Infrastructure.ViewModel.KhoKhan;

namespace SER.Infrastructure.Mapping
{
    public class MapperInitializer:Profile
    {
        public MapperInitializer()
        {
            //Du an
            CreateMap<Duan, DuAnReponse>().ReverseMap();
            CreateMap<Duan, DuAnResquest>().ReverseMap();
            //Kho khan
            CreateMap<Khokhan, KhoKhanReponse>().ReverseMap();
            CreateMap<Khokhan, KhoKhanResquest>().ReverseMap();
        }
    }
}
