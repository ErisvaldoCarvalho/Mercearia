using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    public class Cliente2
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        [Column(TypeName = "varchar(150)")]
        public string Email { get; set; }
    }
    public class DataContext : DbContext
    {
        public DbSet<CategoriaProduto> CategoriaProduto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Cliente2> Cliente2 { get; set; }

        public DbSet<Compra> Compra { get; set; }
        public DbSet<ContasAReceber> ContasAReceber { get; set; }
        public DbSet<ContasAPagar> ContasAPagar { get; set; }
        public DbSet<DepartamentoProduto> DepartamentoProduto { get; set; }
        public DbSet<FixaKardex> FixaKardex { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<GrupoProduto> GrupoProduto { get; set; }
        public DbSet<GrupoUsuario> GrupoUsuario { get; set; }
        public DbSet<ItemCompra> ItemCompra { get; set; }
        public DbSet<ItemContasAReceber> ItemContasAReceber { get; set; }
        public DbSet<ItemContasAPagar> ItemContasAPagar { get; set; }
        public DbSet<ItemVenda> ItemVenda { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Permissao> Permissao { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<SubGrupoProduto> SubGrupoProduto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Venda> Venda { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Conexao.StringDeConexao);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aplica a configuração global para todas as entidades
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GlobalEntityTypeConfiguration<>).Assembly);

            // ...


            base.OnModelCreating(modelBuilder);
        }
    }

    public class GlobalEntityTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            // Verifica se a entidade possui uma propriedade chamada "Email" e define o tamanho máximo
            TiposColuna(builder, "Email", "VARCHAR(150)");
            TiposColuna(builder, "Descricao");
            TiposColuna(builder, "Nome");
            TiposColuna(builder, "NomeUsuario");
            TiposColuna(builder, "Senha", "VARCHAR(32)");
            TiposColuna(builder, "Fone", "VARCHAR(15)");
        }
        private void TiposColuna(EntityTypeBuilder<TEntity> _builder, string _coluna, string _tipo = "VARCHAR(150)")
        {
            var emailProperty = _builder.Property<string>(_coluna);
            if (emailProperty != null)
                emailProperty.HasColumnType(_tipo);
        }
    }
}