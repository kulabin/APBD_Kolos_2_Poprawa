using APBD_Kolos_2_Poprawa.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Kolos_2_Poprawa.Controllers;


[ApiController]
[Route("api/[controller]")]
public class AController : ControllerBase
{
    private readonly AService _service;
    
    public AController(AService service)
    {
        _service = service;
    }
}