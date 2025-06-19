using Microsoft.AspNetCore.Mvc;
using APBD_Kolos_2_Poprawa.Services;
using APBD_Kolos_2_Poprawa.DTOs;

namespace APBD_Kolos_2_Poprawa.Controllers;


[ApiController]
[Route("api/[controller]")]
public class BController : ControllerBase
{
    private readonly BService _service;

    public BController(BService service)
    {
        _service = service;
    }
}