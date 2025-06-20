using APBD_Kolos_2_Poprawa.DTOs;
using APBD_Kolos_2_Poprawa.Models;
using APBD_Kolos_2_Poprawa.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Kolos_2_Poprawa.Controllers;


[ApiController]
[Route("api/[controller]")]
public class PlayerController : ControllerBase
{
    private readonly PlayerService _service;
    
    public PlayerController(PlayerService service)
    {
        _service = service;
    }

    [HttpGet("{id:int}/matches")]
    public async Task<IActionResult> GetPlayers(int id)
    {
        var player = await _service.GetPlayerByIdAsync(id);
        return Ok(player);
    }

    [HttpPost]
    public async Task<IActionResult> AddPlayer([FromBody] AddPlayerDto player)
    {
        await _service.AddPlayerAsync(player);
        return Ok();
    }
}