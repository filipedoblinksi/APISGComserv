using Microsoft.AspNetCore.Mvc;
using SGComserv.Context;
using SGComserv.DbContextApp;

namespace SGComserv.Controllers;

[ApiController]
[Route("[Controller]")]
public class ProductOrderController : Controller
{
    private readonly SGComServDbContext _dbContext;

    public ProductOrderController(SGComServDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet("GetByID")]
    public async Task<ActionResult> GetProductOrder([FromQuery] int idProductInOrder)
        => Ok(await new ProdutoPedidoContext(_dbContext).Get(idProdutoPedido: idProductInOrder));

    [HttpGet("Get")]
    public async Task<ActionResult> GetProductOrder([FromQuery] int idOrder, [FromQuery] int idProduct)
        => Ok(await new ProdutoPedidoContext(_dbContext).Get(idPedido: idOrder, idProduto: idProduct));

    [HttpGet("GetListByOrder")]
    public async Task<ActionResult> GetListProductsOrder([FromQuery] int idOrder)
        => Ok(await new ProdutoPedidoContext(_dbContext).GetListProductsOrder(idPedido: idOrder));
}
