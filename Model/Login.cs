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
      [Table("session")]
    public class Session
    {
    [Key]
    public int Id { get; set; }
    [Column("username")]
    public string? Username { get; set; }
    [Column("entered_date")]
    public DateTime EnteredDate { get; set; }
    [Column("status")]
    public int Status { get; set; }
    }
}