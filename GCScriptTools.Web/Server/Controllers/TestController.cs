using Microsoft.AspNetCore.Mvc;

namespace GCScriptTools.Web.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    [HttpGet] public ActionResult<string> Get() {
        return "Teste...";
    }
}
