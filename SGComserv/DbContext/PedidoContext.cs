using Microsoft.EntityFrameworkCore;
using SGComserv.DbContextApp;
using SGComserv.Entitys;
using System.Data;

namespace SGComserv.Context;

public class PedidoContext
{
    private readonly SGComServDbContext _context;

    public PedidoContext(SGComServDbContext context)
    {
        _context = context;
    }

    public async Task<PedidoEntity?> Get(int idPedido) => await _context.Pedidos
            .Include(c => c.DadosEmpresa)
            .Include(c => c.DadosCliente)
            .Include(c => c.DadosTipoEntrega)
            .Include(c => c.DadosUsuarioCriacao)
            .FirstOrDefaultAsync(c => c.Id == idPedido);

    public async Task<List<PedidoEntity>> GetList(bool excluido,bool fechado,int idCriador = 0,bool somenteDesteVendedor = true)
    {
        var query = _context.Pedidos
            .Include(c => c.DadosCliente)
            .Include(c => c.DadosEmpresa)
            .Include(c => c.DadosTipoEntrega)
            .Include(c => c.DadosUsuarioCriacao)
            .AsNoTracking()
            .AsQueryable();

        query = query.Where(p => p.Excluido == excluido);

        if (idCriador > 0 && somenteDesteVendedor) query = query.Where(p => p.IdCriador == idCriador);

        if (fechado) query = query.Where(p => p.DataFechamento != null);
        else query = query.Where(p => p.DataFechamento == null);

        return await query.ToListAsync();
    }

    public async Task<List<PedidoEntity>> GetListApproveOrders()
    {
        var query = _context.Pedidos
            .Include(c => c.DadosCliente)
            .Include(c => c.DadosEmpresa)
            .Include(c => c.DadosTipoEntrega)
            .Include(c => c.DadosUsuarioCriacao)
            .AsNoTracking()
            .AsQueryable();

        query = query.Where(p => p.Excluido == false && p.DataFechamento == null && p.SolicitacaoAprovacao);

        return await query.ToListAsync();
    }
}
