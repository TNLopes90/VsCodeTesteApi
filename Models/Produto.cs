using System;

namespace VsCodeTesteApi.Models
{
	public class Produto
	{
		public int Id { get; set; }
		public string Titulo { get; set; }
		public string Descricao { get; set; }
		public decimal Preco { get; set; }
		public int Quantidade { get; set; }
		public string Imagem { get; set; }
		public DateTime DataCriacao { get; set; }
		public DateTime DataAtualizacao { get; set; }
		public int IdCategoria { get; set; }
		public Categoria Categoria { get; set; }
	}
}