using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;

namespace Bark
{
  [ApiController]
  [Route("api/[controller]")]
  public class CreateProjectController : ControllerBase
  {
    [Route("")]
    [HttpGet("{id}")]
    public async Task<ActionResult> Get(string id)
    {
      DbUtils.CreateProject(id);
      return Ok();
    }
  }
}
