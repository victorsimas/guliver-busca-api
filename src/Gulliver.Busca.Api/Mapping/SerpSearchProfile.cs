using AutoMapper;
using Gulliver.Busca.Api.Models;
using Gulliver.Busca.Api.Views;

namespace Gulliver.Busca.Api.Mapping
{
    public class SerpSearchProfile : Profile
    {
        public SerpSearchProfile()
        {
            MapearSerpSearchResponse();
        }

        private void MapearSerpSearchResponse()
        {
            CreateMap<SerpEngineResponse, BuscaResponse>()
                .ForMember(dest => dest.Hotels, opts => opts.MapFrom(src => src.PlacesResults))
                .ForPath(dest => dest.Location, opts => opts.MapFrom(src => src.SearchParameters.Location.Replace("+"," ")));

            CreateMap<PlacesResult, Hotel>()
                .ForMember(dest => dest.Rating, opts => opts.MapFrom(src => src.Rating))
                .ForMember(dest => dest.Text, opts => opts.MapFrom(src => src.Title))
                .ForMember(dest => dest.TextDescription, opts => opts.MapFrom(src => src.Snippet))
                .ForMember(dest => dest.Img, opts => opts.MapFrom(src => src.Link))
                .ForMember(dest => dest.AverageOfStay, opts => opts.MapFrom(src => src.Reviews.ToString()));
        }
    }
}