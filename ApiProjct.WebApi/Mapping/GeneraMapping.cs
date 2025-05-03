
using ApiProjct.WebApi.Dtos.FeatureDtos;
using ApiProject.WebApi.Entities;
using AutoMapper;

namespace ApiProjct.WebApi.Mapping;

public class GeneraMapping : Profile
{
    public GeneraMapping()
    {
        CreateMap<Feature, ResultFeatureDto>().ReverseMap();
        CreateMap<Feature, GetByIdFeatureDto>().ReverseMap();
        CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
        CreateMap<Feature, CreateFeatureDto>().ReverseMap();

        CreateMap<Message, CreateFeatureDto>().ReverseMap();
        CreateMap<Message, GetByIdFeatureDto>().ReverseMap();
        CreateMap<Message, ResultFeatureDto>().ReverseMap();
        CreateMap<Message, UpdateFeatureDto>().ReverseMap();
    }
}
