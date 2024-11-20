using Microsoft.AspNetCore.Mvc;
using SGComserv.Context;
using SGComserv.DbContextApp;

namespace SGComserv.Controllers;

[ApiController]
[Route("[Controller]")]
public class PedidoController : Controller
{
    private readonly SGComServDbContext _dbContext;

    public PedidoController(SGComServDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet("Get")]
    public async Task<ActionResult> GetOrder(int id)
        => Ok(await new PedidoContext(_dbContext).Get(id));

    [HttpGet("GetListFilter")]
    public async Task<ActionResult> GetListFilterOrders(
        [FromQuery] bool excluido = false,
        [FromQuery] bool fechado = false,
        [FromQuery] int idCriador = 0,
        [FromQuery] bool somenteDesteVendedor = true)
        => Ok(await new PedidoContext(_dbContext).GetList(excluido, fechado, idCriador, somenteDesteVendedor));

    [HttpGet("GetListApprove")]
    public async Task<ActionResult> GetListApproveOrders()
        => Ok(await new PedidoContext(_dbContext).GetListApproveOrders());

}
