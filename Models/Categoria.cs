using System.Collections.Generic;

namespace VsCodeTesteApi.Models
{
	public class Categoria
	{
		public int Id { get; set; }
		public string Titulo { get; set; }
		public IEnumerable<Produto> Produtos { get; set; }
	}
}