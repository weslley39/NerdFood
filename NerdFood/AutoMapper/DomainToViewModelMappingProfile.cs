using AutoMapper;
using NerdFood.Domain;
using NerdFood.ViewModels;

namespace NerdFood.Presentation.Web.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            //Mapper.CreateMap<PublicacaoViewModel, Publicacao>();
        }
    }
}