using AutoMapper;
using Core.Entities;
using FrequencyDTO = Core.DTO.FrequencyDTO.FrequencyDTO;

namespace Core.Profiles
{
    public class FrequencyProfile : Profile
    {
        public FrequencyProfile()
        {
            CreateMap<Frequency, FrequencyDTO>();
        }
    }
}
