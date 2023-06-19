using AutoMapper;
using HotelProject.DtoLayer.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig() 
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();

            CreateMap<RoomUpdateDto, Room>().ReverseMap(); /*burde reversemap eklediğimiz için yukarıdaki gibi 
                                                            iki kere yazmaya gerek kalmadı.Otomatik olarak tersini de almış                                oluyor */
        }
    }
}
