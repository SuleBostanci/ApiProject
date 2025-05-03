using ApiProjct.WebApi.ApiContext;
using ApiProjct.WebApi.Dtos.ContactDtos;
using ApiProject.WebApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjct.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ContactController : ControllerBase
{
    readonly BaseContext _ctx;

    public ContactController(BaseContext context)
    {
        _ctx = context;
    }
    [HttpGet]
    public IActionResult ConttactList()
    {
        var value = _ctx.Contacts.ToList();
        return Ok(value);
        //return Ok(_ctx.Contacts.ToList());
    }
    [HttpPost]
    public IActionResult CreateContact(CreateContactDto createContactDto)
    {
        Contact contact = new Contact()
        {
            Adress = createContactDto.Adress,
            Email = createContactDto.Email,
            MapLocation = createContactDto.MapLocation,
            OpenHours = createContactDto.OpenHours,
            Phone = createContactDto.Phone,
        };
        _ctx.Contacts.Add(contact);
        _ctx.SaveChanges();
        return Ok();
    }
    [HttpDelete]
    public IActionResult DeleteContact(int id)
    {
        var value = _ctx.Contacts.Find(id);
        _ctx.Remove(value);
        _ctx.SaveChanges();
        return Ok("Silme İşlemi Başarılı");
    }
    [HttpGet("GetByİd")]
    public IActionResult GetContact(int id)
    {
        var value = _ctx.Contacts.Find(id);
        return Ok();
    }
    [HttpPut]
    public IActionResult UpdateContact(UpdateContactDto updateContactDto)
    {
        Contact contact = new Contact()
        {
            Adress = updateContactDto.Adress,
            Email = updateContactDto.Email,
            MapLocation = updateContactDto.MapLocation,
            OpenHours = updateContactDto.OpenHours,
            Phone = updateContactDto.Phone,
            Id = updateContactDto.Id

        };
        _ctx.Contacts.Update(contact);
        _ctx.SaveChanges();
        return Ok("Başarıyla Güncellendi");
    }


}
