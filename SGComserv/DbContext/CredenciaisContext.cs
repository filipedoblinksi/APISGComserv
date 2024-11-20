using Microsoft.EntityFrameworkCore;
using SGComserv.DbContextApp;
using SGComserv.Entitys;
using SGComserv.Extensions;
using System.Data;

namespace SGComserv.Context;

public class CredenciaisContext
{
    private readonly SGComServDbContext _context;

    public CredenciaisContext(SGComServDbContext context)
    {
        _context = context;
    }

    public async Task<UsuarioEntity?> Login(CredenciaisEntity user)
    {
        var usuario = await _context.Credenciais
            .FirstOrDefaultAsync(u => u.NomeUsuario == user.NomeUsuario);

        if (usuario == null)
        {
            return null;
        }

        bool senhaValida = BCrypt.Net.BCrypt.Verify(user.Senha, usuario.HashSenha);

        if (!senhaValida)
        {
            return null;
        }

        var dadosUsuario = await _context.Usuarios
            .FirstOrDefaultAsync(u => u.Nome == user.NomeUsuario);

        return dadosUsuario;
    }
}
