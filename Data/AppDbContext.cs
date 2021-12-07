using Microsoft.EntityFrameworkCore;

namespace ApiFilmes.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Filme> Filmes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Filme>()
                .HasData(
                    new Filme { Id = 1, Titulo = "A volta dos que não foram", Ano = "2069", Duracao = "2 horas", FaixaEtaria = "+18", Genero = "Ação" },
                    new Filme { Id = 2, Titulo = "As tranças do rei careca", Ano = "2069", Duracao = "2 horas", FaixaEtaria = "+18", Genero = "Ação" },
                    new Filme { Id = 3, Titulo = "Poeira em alto mar", Ano = "2069", Duracao = "2 horas", FaixaEtaria = "+18", Genero = "Ação" }
                );
        }
    }
}
