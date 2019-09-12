using System;
using Flunt.Notifications;
using Flunt.Validations;
using VsCodeTesteApi.Models;

namespace VsCodeTesteApi.ViewModels.ProdutoViewModel
{
	public class ProdutoListViewModel : PadraoViewModel
	{
		public int Id { get; set; }
		public string Titulo { get; set; }
		public string Descricao { get; set; }
		public decimal Preco { get; set; }
		public int Quantidade { get; set; }
		public string TituloCategoria { get; set; }
	}
}