using Microsoft.AspNetCore.Mvc;
using Algoriza_Project_2023BE83.Models;
using Core.Domain;
using Core.Repository;
namespace Algoriza_Project_2023BE83.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUsersRepository _patientsService;
    public UsersController(IUsersRepository patientsService)
    {
        _patientsService = patientsService;
    }
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] Users usersmodel)
    {
        await _patientsService.Register(usersmodel);
        return Ok();
    }
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] Users usersmodel)
    {
        await _patientsService.Login(usersmodel);
        return Ok();
    }
    [HttpGet("")]
    public async Task<IActionResult> GetAllPatients()
    {
        var patients = await _patientsService.GetAllPatients();
        return Ok(patients);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetPatientById([FromRoute]int id)
    {
        var patient = await _patientsService.GetPatientByIdAsync(id);
        if (patient == null)
        {
            return NotFound();
        }
        return Ok(patient);
    }     
}