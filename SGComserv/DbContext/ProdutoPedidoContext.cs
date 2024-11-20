using Microsoft.EntityFrameworkCore;
using SGComserv.DbContextApp;
using SGComserv.Entitys;
using SGComserv.Enums;
using SGComserv.Models;
using System.Data;

namespace SGComserv.Context;

public class ProdutoPedidoContext
{
    private readonly SGComServDbContext _context;

    public ProdutoPedidoContext(SGComServDbContext context)
    {
        _context = context;
    }

    public async Task<ProdutoPedidoViewModel?> Get(int idProdutoPedido) => await _context.ProdutosPedido
            .Include(c => c.DadosProduto)
            .FirstOrDefaultAsync(c => c.Id == idProdutoPedido);

    public async Task<ProdutoPedidoViewModel?> Get(int idPedido, int idProduto) => await _context.ProdutosPedido
        .Include(c => c.DadosProduto)
        .FirstOrDefaultAsync(c => c.IdPedido == idPedido && c.IdProduto == idProduto);

    public async Task<List<ProdutoPedidoViewModel>> GetListProductsOrder(int? idPedido = null)
    {
        var query = from produtoPedido in _context.ProdutosPedido
                    join pedido in _context.Pedidos on produtoPedido.IdPedido equals pedido.Id into pedidoJoin
                    from pedido in pedidoJoin.DefaultIfEmpty()
                    join preco in _context.PrecoProdutos on produtoPedido.IdProduto equals preco.IdProduto into precosJoin
                    from preco in precosJoin.DefaultIfEmpty()
                    join subTabela in _context.SubTabelasVenda on preco.IdSubTabela equals subTabela.Id into subTabelasJoin
                    from subTabela in subTabelasJoin.DefaultIfEmpty()
                    join empresa in _context.Empresas on subTabela.IdTabelaVenda equals empresa.IdTabelaVenda into empresasJoin
                    from empresa in empresasJoin.DefaultIfEmpty()
                    where (!idPedido.HasValue || produtoPedido.IdPedido == idPedido.Value) &&
                          (pedido == null || empresa.Id == pedido.IdEmpresa) &&
                          (subTabela == null || (subTabela.Padrao && subTabela.Ativo)) &&
                          (empresa == null || empresa.IdTabelaVenda == 0 || empresa.IdTabelaVenda != 0)
                    select new ProdutoPedidoViewModel
                    {
                        Id = produtoPedido.Id,
                        DadosProduto = produtoPedido.DadosProduto,
                        DataDescontoLiberado = produtoPedido.DataDescontoLiberado,
                        DescontoLiberado = produtoPedido.DescontoLiberado,
                        DifalCalculado = produtoPedido.DifalCalculado,
                        Estoque = produtoPedido.Estoque,
                        IdPedido = produtoPedido.IdPedido,
                        IdProduto = produtoPedido.IdProduto,
                        IdUsuarioDescontoLiberado = produtoPedido.IdUsuarioDescontoLiberado,
                        IpiCalculado = produtoPedido.IpiCalculado,
                        Item = produtoPedido.Item,
                        Observacoes = produtoPedido.Observacoes,
                        PercDescontoCalculado = produtoPedido.PercDescontoCalculado,
                        PercDescontoLiberado = produtoPedido.PercDescontoLiberado,
                        Quantidade = produtoPedido.Quantidade,
                        QuantidadeDevolvida = produtoPedido.QuantidadeDevolvida,
                        StCalculado = produtoPedido.StCalculado,
                        ValorOutros = produtoPedido.ValorOutros,
                        ValorUnitario = produtoPedido.ValorUnitario,

                        ValorUnitarioTabela = (empresa == null || empresa.IdTabelaVenda == 0)
                            ? 0
                            : (empresa.IdModelo == (int)EModeloEmpresa.DISTRIBUIDORA
                                ? preco.ValorAtacado
                                : preco.ValorVarejo),

                        DadosPrecoProduto = new PrecoProdutoEntity
                        {
                            IdSubTabela = preco.IdSubTabela,
                            IdProduto = preco.IdProduto,
                            ValorVarejo = preco.ValorVarejo,
                            ValorAtacado = preco.ValorAtacado,
                            ValorPromocional = preco.ValorPromocional
                        }
                    };

        return await query.ToListAsync();
    }
}
