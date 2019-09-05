using Microsoft.EntityFrameworkCore;
using VsCodeTesteApi.Data.Maps;
using VsCodeTesteApi.Models;

namespace Data.DataContext
{
	public class DataContext : DbContext
	{
		public DbSet<Produto> Produtos { get; set; }
		public DbSet<Categoria> Categorias { get; set; }
		

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseInMemoryDatabase();
		}

		protected  override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new CategoriaMap());
			modelBuilder.ApplyConfiguration(new ProdutoMap());
		}
	}
}