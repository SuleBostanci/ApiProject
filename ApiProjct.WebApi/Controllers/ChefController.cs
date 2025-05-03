using ApiProjct.WebApi.ApiContext;
using ApiProject.WebApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjct.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ChefController : ControllerBase
{
    readonly BaseContext _ctx;

    public ChefController(BaseContext ctx)
    {
        _ctx = ctx;
    }
    [HttpGet]
    public IActionResult ChefList()
    {
        var value = _ctx.Chefs.ToList();
        return Ok(value);
    }
    [HttpPost]
    public IActionResult CreateChef(Chef chef)
    {
        _ctx.Chefs.Add(chef);
        _ctx.SaveChanges();
        return Ok("Başarıyla Eklendi");
    }
    [HttpDelete]
    public IActionResult DeleteChef(int id)
    {
        var value = _ctx.Chefs.Find(id);
        _ctx.Chefs.Remove(value);
        _ctx.SaveChanges();
        return Ok("Başarıyla Silindi");
    }
    [HttpPut]
    public IActionResult UpdateChef(Chef chef)
    {
        _ctx.Chefs.Update(chef);
        _ctx.SaveChanges();
        return Ok("Başarıyla Güncellendi");
    }
    [HttpGet("GetById")]
    public IActionResult GetById(int id)
    {
        return Ok(_ctx.Chefs.Find(id));
    }
}
