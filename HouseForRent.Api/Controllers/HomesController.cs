using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace HouseForRent.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomesController : RESTFulController
{
    [HttpGet]
    public IActionResult Get() => Ok("Hello");
}