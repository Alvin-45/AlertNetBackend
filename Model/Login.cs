using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace alertnetBackend.Model
{
    [Table("employee_master")]
  public class Login{
    [Column("username")]
    public string username{get;set;}
    [Column("password")]
    public string password{get;set;}
  }  
      
}