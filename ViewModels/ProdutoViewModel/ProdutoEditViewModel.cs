using System;
using Flunt.Notifications;
using Flunt.Validations;

namespace VsCodeTesteApi.ViewModels.ProdutoViewModel
{
	public class ProdutoEditViewModel : Notifiable, IValidatable
	{
		public int Id { get; set; }
		public string Titulo { get; set; }
		public string Descricao { get; set; }
		public decimal Preco { get; set; }
		public int Quantidade { get; set; }
		public string Imagem { get; set; }
		public int IdCategoria { get; set; }
		public DateTime? DataCriacao { get; set; }

		public void Validate() => AddNotifications
			(
				new Contract()
					.HasMaxLen(Titulo, 300, "Titulo", "O Título não pode ter mais de 300 caracteres!")
					.HasMaxLen(Descricao, 1024, "Descricao", "A descrição não pode ter mais de 1024 caracteres!")
					.IsGreaterThan(Preco, 0, "Preco", "O valor do produto de ser maior que R$0,00!")
					.IsGreaterOrEqualsThan(Quantidade, 1, "Quantidade", "A quantidade deve ser maior que 0!")
			);
	}
}