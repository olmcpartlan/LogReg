using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AngularLogReg.Models
{
  public class Users
  {
    public List<user> user { get; set; }
  }
  public class user
  {
    // meant to be simple, not really interested in over complicating this
    [Key]
    public int userId { get; set; }
    public string username { get; set; }
    public string password { get; set; }
  }

  public class UserComplete
  {
    public int userId { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }

  }
}
