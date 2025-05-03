using ApiProjct.WebApi.ApiContext;
using ApiProject.WebApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjct.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]

public class CategoryController : ControllerBase
{
    readonly BaseContext _context;

    public CategoryController(BaseContext context)
    {
        _context = context;
    }
    [HttpGet]
    public IActionResult CategoryList()
    {
        var value = _context.Categories.ToList();
        return Ok(value);
    }
    [HttpPost]
    public IActionResult CreateCategory(Category category)
    {
        _context.Categories.Add(category);
        _context.SaveChanges();
        return Ok("Başarıyla Ekleni");
    }
    [HttpDelete]
    public IActionResult DeleteCattegory(int id)
    {
        var value = _context.Categories.Find(id);
        _context.Categories.Remove(value);
        _context.SaveChanges();
        return Ok("Başarıyla Silindi");
    }
    [HttpGet("GetById")]
    public IActionResult GetCategory(int id)
    {
        var value = _context.Categories.Find(id);
        return Ok(value);
    }
    [HttpPut]
    public IActionResult PutCategory(Category category)
    {
        _context.Categories.Update(category);
        _context.SaveChanges();
        return Ok(category);
    }

}
