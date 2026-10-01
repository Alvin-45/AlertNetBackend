using Microsoft.EntityFrameworkCore;
namespace alertnetBackend.Model;

public class LoginContext:DbContext
{
    public LoginContext(DbContextOption<LoginContext> options):base(options)
        public Dbset<Login>Login{get;set;}=null!;
        public Dbset<Session>Session{get;set;}=null!;
    }
}
