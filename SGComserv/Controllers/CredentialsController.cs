using Microsoft.AspNetCore.Mvc;
using SGComserv.Context;
using SGComserv.DbContextApp;
using SGComserv.Entitys;

namespace SGC.Controllers;
[ApiController]
[Route("[Controller]")]
public class CredentialsController : Controller {

    private readonly SGComServDbContext _dbContext;

    public CredentialsController(SGComServDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost("Login")]
    public async Task<ActionResult> LoginAsync([FromBody] CredenciaisEntity user)
    {
        UsuarioEntity? userAuthenticated = await new CredenciaisContext(_dbContext).Login(user);

        if (userAuthenticated != null)
        {
            return Ok(userAuthenticated);
        }
        else
        {
            return Unauthorized();
        }
    }
}