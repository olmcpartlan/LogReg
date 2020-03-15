using System.IO;
using System.Linq;
using Newtonsoft.Json;
using AngularLogReg.Data;
using AngularLogReg.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AngularLogReg.Controllers
{
  [Route("db")]
  [ApiController]
  public class DbController : ControllerBase
  {
    private readonly UserContext _context;

    public DbController(UserContext context)
    {
      _context = context;
    }

    [HttpPost("adduser")]
    public user CreateUser([FromBody] object user)
    {
      _context.Add(JsonConvert.DeserializeObject<user>(user.ToString()));
      _context.SaveChanges();
      return _context.user.FirstOrDefault();
    }
  }

}
