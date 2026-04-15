using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using StudentAPI.Services;
using Microsoft.AspNetCore.Authorization;


namespace StudentAPI.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private readonly IStudentService _service;

    public StudentsController(IStudentService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
        => Ok(await _service.GetAll());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
        => Ok(await _service.GetById(id));

    [HttpPost]
    public async Task<IActionResult> Add(Student student)
    {
        await _service.Add(student);
        return Ok("Student Added");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Student student)
    {
        student.Id = id;
        await _service.Update(student);
        return Ok("Updated");
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.Delete(id);
        return Ok("Deleted");
    }
}