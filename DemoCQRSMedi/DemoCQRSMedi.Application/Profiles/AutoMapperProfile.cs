using AutoMapper;
using DemoCQRSMedi.Application.Features.Commande.Commands.Create;
using DemoCQRSMedi.Application.Features.Commande.Queries.GetDetail;
using DemoCQRSMedi.Application.Features.Commande.Queries.GetList;
using DemoCQRSMedi.Domain;


namespace DemoCQRSMedi.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Commande, CommandeDto>().ReverseMap();
            CreateMap<Commande , CommandeDetailDto>().ReverseMap();
            CreateMap<Commande, CreateCommandeCommand>().ReverseMap();

        }
    }
}
