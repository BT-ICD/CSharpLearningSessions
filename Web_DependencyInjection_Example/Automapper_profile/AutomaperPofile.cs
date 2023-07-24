using AutoMapper;
using Web_DependencyInjection_Example.Models;

namespace Web_DependencyInjection_Example.Automapper_profile
{
    public class AutomaperPofile:Profile
    {
        public AutomaperPofile()
        {
            //CreateMap(Source, Destination)
            CreateMap< ProductDTOAdd,Product>();
        }
    }
}
