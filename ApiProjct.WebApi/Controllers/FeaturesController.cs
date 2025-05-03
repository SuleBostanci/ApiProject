using ApiProjct.WebApi.ApiContext;
using ApiProjct.WebApi.Dtos.FeatureDtos;
using ApiProject.WebApi.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjct.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class FeaturesController : ControllerBase
{
    readonly IMapper _mapper;
    readonly BaseContext _baseContext;

    public FeaturesController(IMapper mapper, BaseContext baseContext)
    {
        _mapper = mapper;
        _baseContext = baseContext;
    }
    [HttpGet]
    public IActionResult FeatureList()
    {
        var values = _baseContext.Features.ToList();
        return Ok(_mapper.Map<List<ResultFeatureDto>>(values));
    }
    [HttpPost]
    public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
    {
        var value = _mapper.Map<Feature>(createFeatureDto);
        _baseContext.Features.Add(value);
        return Ok(value);
    }
}
