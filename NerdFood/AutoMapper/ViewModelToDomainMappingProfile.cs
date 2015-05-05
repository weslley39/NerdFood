using AutoMapper;
using NerdFood.Domain;
using NerdFood.ViewModels;

namespace NerdFood.Presentation.Web.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            //Mapper.CreateMap<Publicacao, PublicacaoViewModel>();
        }
    }
}