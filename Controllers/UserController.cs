using AngularLogReg.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AngularLogReg.Controllers
{
  [Route("api")]
  [ApiController]
  public class UserController : ControllerBase
  {
    [Route("")]
    public string GetHome()
    {
      return "some string";
    }
  }
}