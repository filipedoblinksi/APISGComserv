using Microsoft.EntityFrameworkCore;
using SGComserv.DbContextApp;
using SGComserv.Entitys;
using SGComserv.Extensions;
using System.Data;

namespace SGComserv.Context;

public class UsuarioContext
{
    private readonly SGComServDbContext _context;

    public UsuarioContext(SGComServDbContext context)
    {
        _context = context;
    }

    public async Task<UsuarioEntity?> Get(int idUsuario)
    {
        return await _context.Usuarios
            .FirstOrDefaultAsync(u => u.Id == idUsuario);
    }

    public async Task<List<UsuarioEntity>> GetList()
    {
        return await _context.Usuarios
            .AsNoTracking()
            .ToListAsync();
    }
}
