using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VsCodeTesteApi.Models;

namespace VsCodeTesteApi.Data.Maps
{
	public class ProdutoMap : IEntityTypeConfiguration<Produto>
	{
		public void Configure(EntityTypeBuilder<Produto> produtoBuilder)
		{
			produtoBuilder.ToTable("Produto");
			produtoBuilder.HasKey(p => p.Id);
			produtoBuilder.Property(p => p.Titulo).IsRequired().HasMaxLength(300).HasColumnType("varchar(300)");
			produtoBuilder.Property(p => p.Descricao).IsRequired().HasMaxLength(1024).HasColumnType("varchar(1024)");
			produtoBuilder.Property(p => p.Preco).IsRequired().HasColumnType("money");
			produtoBuilder.Property(p => p.Quantidade).IsRequired();
			produtoBuilder.Property(p => p.Imagem).IsRequired().HasMaxLength(1024).HasColumnType("varchar(1024)");
			produtoBuilder.Property(p => p.DataCriacao).IsRequired();
			produtoBuilder.Property(p => p.DataAtualizacao).IsRequired();
			produtoBuilder.HasOne(p => p.Categoria).WithMany(c => c.Produtos).HasForeignKey(c => c.IdCategoria);
		}
	}
}