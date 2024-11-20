using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Console;
using SGComserv.Models;

using SGComserv.Entitys;
namespace SGComserv.DbContextApp
{
    public class SGComServDbContext : DbContext
    {
        public SGComServDbContext(DbContextOptions<SGComServDbContext> options)
            : base(options)
        {
        }
        public DbSet<CredenciaisEntity> Credenciais { get; set; }
        public DbSet<UsuarioEntity> Usuarios { get; set; }
        public DbSet<ClienteEntity> Clientes { get; set; }
        public DbSet<FornecedorEntity> Fornecedores { get; set; }
        public DbSet<EmpresaEntity> Empresas { get; set; }
        public DbSet<ClasseClienteEntity> ClassesClientes { get; set; }
        public DbSet<CidadeEntity> Cidades { get; set; }
        public DbSet<PlanoFinanceiroEntity> PlanosFinanceiros { get; set; }
        public DbSet<PlanoContabilEntity> PlanosContabeis { get; set; }
        public DbSet<RegraPlanoFinanceiroCCEntity> RegraPlanoFinanceiroCCs { get; set; }
        public DbSet<CentroCustoEntity> CentroCustos { get; set; }
        public DbSet<ClasseDeValorEntity> ClassesDeValor { get; set; }

        public DbSet<PedidoEntity> Pedidos { get; set; }

        public DbSet<PrecoProdutoEntity> PrecoProdutos { get; set; }
        
        public DbSet<SubTabelaVendaEntity> SubTabelasVenda { get; set; }

        public DbSet<ProdutoPedidoViewModel> ProdutosPedido { get; set; }

        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLoggerFactory(MyLoggerFactory);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClienteEntity>(entity =>
            {
                entity.HasKey(c => c.Id);

                entity.HasOne<FornecedorEntity>(c => c.Vendedor)
                    .WithMany()
                    .HasForeignKey(c => c.IdVendedor)
                    .HasPrincipalKey(fo => new { fo.id });

                entity.HasOne<ClasseClienteEntity>(c => c.ClasseDoCliente)
                    .WithMany()
                    .HasForeignKey(c => c.IdClasse)
                    .HasPrincipalKey(cc => new { cc.Id });

                entity.HasOne<SetorEntregaEntity>(c => c.SetorEntregaCliente)
                    .WithMany()
                    .HasForeignKey(c => c.IdSetor)
                    .HasPrincipalKey(cc => new { cc.Id });

                entity.HasOne(c => c.CidadeCadastro)
                    .WithMany()
                    .HasForeignKey(c => c.End_cmun)
                    .HasPrincipalKey(ci => ci.Id);

                entity.HasOne(c => c.CidadeEntrega)
                    .WithMany()
                    .HasForeignKey(c => c.Ent_cmun)
                    .HasPrincipalKey(ci => ci.Id);

                entity.HasOne(c => c.CidadeCobranca)
                    .WithMany()
                    .HasForeignKey(c => c.Cob_cmun)
                    .HasPrincipalKey(ci => ci.Id);
            });

            modelBuilder.Entity<FornecedorEntity>(entity =>
            {
                entity.HasKey(f => f.id);

                entity.HasOne(f => f.DadosEmpresa)
                    .WithMany()
                    .HasForeignKey(f => f.idEmpresa)
                    .HasPrincipalKey(emp => new { emp.Id }); ;

                entity.HasOne(f => f.DadosClasseFornecedor)
                    .WithMany()
                    .HasForeignKey(f => f.idClasse)
                    .HasPrincipalKey(cf => new { cf.Id }); ;

                entity.HasOne(f => f.DadosPlanoContabil)
                    .WithMany()
                    .HasForeignKey(f => f.idContabilFornecedor)
                    .HasPrincipalKey(pc => pc.IdPlanoContabil);

                entity.HasOne(f => f.DadosPlanoFinanceiro)
                    .WithMany()
                    .HasForeignKey(f => f.IdPlanoFinanceiro)
                    .HasPrincipalKey(pc => pc.IdPlanoFinanceiro);

                entity.HasOne(f => f.DadosTipoGasto)
                    .WithMany()
                    .HasForeignKey(f => f.idTipoGasto)
                    .HasPrincipalKey(tg => tg.Id);

                entity.HasOne(f => f.DadosTipoDocumentoFinanceiro)
                    .WithMany()
                    .HasForeignKey(f => f.idCTipoPagamento)
                    .HasPrincipalKey(tdf => tdf.Id);
            });

            modelBuilder.Entity<EmpresaEntity>(entity =>
            {
                entity.HasKey(c => c.Id);
            });

            modelBuilder.Entity<ProdutoEntity>(entity =>
            {
                entity.HasKey(c => c.IdProduto);
            });

            modelBuilder.Entity<CentroCustoEntity>(entity =>
            {
                entity.HasKey(c => c.id);
            });

            modelBuilder.Entity<ClasseDeValorEntity>(entity =>
            {
                entity.HasKey(c => c.id);
            });

            modelBuilder.Entity<TipoDocumentoFinanceiroEntity>(entity =>
            {
                entity.HasKey(c => c.Id);
            });

            modelBuilder.Entity<TipoGastoEntity>(entity =>
            {
                entity.HasKey(c => c.Id);
            });

            modelBuilder.Entity<PrecoProdutoEntity>(entity =>
            {
                entity.HasKey(c => new { c.IdSubTabela, c.IdProduto });
            });

            modelBuilder.Entity<PlanoFinanceiroEntity>(entity =>
            {
                entity.HasKey(c => new { c.IdPlanoFinanceiro });

                entity.HasOne(f => f.DadosPlanoContabil)
                    .WithMany()
                    .HasForeignKey(f => f.IdPlanoContabil)
                    .HasPrincipalKey(pc => pc.IdPlanoContabil);

                entity.HasOne(f => f.DadoTipoDocumentoFinanceiro)
                    .WithMany()
                    .HasForeignKey(f => f.IdTipoDocumento)
                    .HasPrincipalKey(pc => pc.Id);

                entity.HasOne(f => f.DadoTipoGasto)
                    .WithMany()
                    .HasForeignKey(f => f.IdTipoGasto)
                    .HasPrincipalKey(pc => pc.Id);

                entity.HasMany(cls => cls.DadosRegraPlanoFinanceiroCC)
                    .WithOne(cls => cls.DadosPlanoFinanceiro)
                    .HasForeignKey(cls => cls.IdPlanoFinanceiro);
            });

            modelBuilder.Entity<PlanoContabilEntity>(entity =>
            {
                entity.HasKey(c => new { c.IdPlanoContabil });
            });

            modelBuilder.Entity<RegraPlanoFinanceiroCCEntity>(entity =>
            {
                entity.HasKey(f => new { f.IdPlanoFinanceiro, f.IdCentroCusto });

                entity.HasOne(f => f.DadosPlanoFinanceiro)
                    .WithMany(pf => pf.DadosRegraPlanoFinanceiroCC)
                    .HasForeignKey(f => f.IdPlanoFinanceiro);

                entity.HasOne(f => f.DadosCentroCusto)
                    .WithMany()
                    .HasForeignKey(f => f.IdCentroCusto)
                    .HasPrincipalKey(cf => new { cf.id }); ;

                entity.HasOne(f => f.DadosPlanoContabil)
                    .WithMany()
                    .HasForeignKey(f => f.IdPlanoContabil)
                    .HasPrincipalKey(pc => pc.IdPlanoContabil);
            });

            modelBuilder.Entity<PedidoEntity>(entity =>
            {
                entity.HasKey(p => p.Id);

                entity.HasOne(p => p.DadosUsuarioCriacao)
                    .WithMany()
                    .HasForeignKey(p => p.IdCriador)
                    .HasPrincipalKey(tdp => new { tdp.Id });

                entity.HasOne(p => p.DadosEmpresa)
                    .WithMany()
                    .HasForeignKey(p => p.IdEmpresa)
                    .HasPrincipalKey(tdp => new { tdp.Id });

                entity.HasOne(p => p.DadosCliente)
                    .WithMany()
                    .HasForeignKey(p => p.IdCliente)
                    .HasPrincipalKey(tdp => new { tdp.Id });

                entity.HasOne(p => p.DadosTipoEntrega)
                    .WithMany()
                    .HasForeignKey(p => p.IdTipoEntrega)
                    .HasPrincipalKey(tdp => new { tdp.Id });

                entity.HasOne(p => p.DadosTranspNFe)
                    .WithMany()
                    .HasForeignKey(p => p.idTranspNFe)
                    .HasPrincipalKey(tdp => new { tdp.id });
            });

            modelBuilder.Entity<ProdutoPedidoViewModel>(entity =>
            {
                entity.HasKey(p => p.Id);

                entity.HasOne(p => p.DadosProduto)
                    .WithMany()
                    .HasForeignKey(p => p.IdProduto)
                    .HasPrincipalKey(tdp => new { tdp.IdProduto });

                entity.HasOne(p => p.DadosPrecoProduto)
                    .WithMany()
                    .HasForeignKey(p => p.IdProduto)
                    .HasPrincipalKey(tdp => new { tdp.IdProduto });
            });
            
            modelBuilder.Entity<PrecoProdutoEntity>(entity =>
            {
                entity.HasKey(c => new { c.IdSubTabela, c.IdProduto });
            });

            modelBuilder.Entity<PrecoProdutoEntity>()
            .HasOne(p => p.DadosSubTabela)
            .WithMany()
            .HasForeignKey(p => p.IdSubTabela);
        }
    }
}
