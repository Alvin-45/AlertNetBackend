using alertnetBackend.Model;
using Microsoft.AspNetCore.Mvc;
using alertnetBackend.Routes;
namespace alertnetBackend.Controller;
[ApiController]
[Route("api/[controller]")]
public class LoginControlller:ControllerBase
{
    private readonly LoginContext _context;
    public LoginControlller(LoginContext context)
    {
        _context=context;
    }
    [HttpPost]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var isValidUser=await _context.Login.Where(s=>s.username==request.Username)
        .Where(s=>s.staus==1).ToListAsync();
        if(isValidUser.Any()){
            var ValidCredentials=await _context.Login.Where(s=>s.username==request.Username).Where(s=>s.password==request.Password);
            if(ValidCredentials.Any()){
                var sessionCheck=await _context.Session.Where(s=>s.username==request.Username)
                .Where(s=>s.staus==1).Where(s=>s.entered_date==DateTime.Today);
                if(sessionCheck.Any()){
                    return BadRequest(new {message="Already session Active!"});
                }
                else{
                return Ok(new {message="Login Success"}) ;
                }
            }
            else{
                return BadRequest(new{message="Invalid Username/Password"});
            }
        }else{
            return BadRequest(new {message="Invalid Username/Password!!"});
        }
    } 
}