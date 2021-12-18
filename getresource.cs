

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Bark
{
  [ApiController]
  [Route("api/[controller]")]
  public class UsersController : ControllerBase
  {
    [Route("")]
    [HttpGet]
    public async Task<ActionResult> Test()
    {
      return Ok();
    }
  }
}
