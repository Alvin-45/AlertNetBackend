using Microsoft.EntityFrameworkCore;
namespace alertnetBackend.Model;

public class LoginContext:DbContext
{
    public LoginContext(DbContextOptions<LoginContext> options):base(options)
    {}
        public DbSet<Login>Login{get;set;}=null!;
        public DbSet<Session>Session{get;set;}=null!;
};

