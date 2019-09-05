using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VsCodeTesteApi.Models;

namespace VsCodeTesteApi.Data.Maps
{
	public class CategoriaMap : IEntityTypeConfiguration<Categoria>
	{
		public void Configure(EntityTypeBuilder<Categoria> categoriaBuilder)
		{
			categoriaBuilder.ToTable("Categoria");
			categoriaBuilder.HasKey(c => c.Id);
			categoriaBuilder.Property(c => c.Titulo).IsRequired().HasMaxLength(300).HasColumnType("varchar(300)");
		}
	}
}