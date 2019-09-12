using System;
using VsCodeTesteApi.Models;
using VsCodeTesteApi.ViewModels.ProdutoViewModel;

namespace VsCodeTesteApi.Translate
{
	public static class ProdutoTranslate
	{
		public static Produto ToModel(this ProdutoEditViewModel produtoEditViewModel) => new Produto 
		{
			Id = produtoEditViewModel.Id,
			Titulo = produtoEditViewModel.Titulo,
			Descricao = produtoEditViewModel.Descricao,
			Preco = produtoEditViewModel.Preco,
			Quantidade = produtoEditViewModel.Quantidade,
			Imagem = produtoEditViewModel.Imagem,
			IdCategoria = produtoEditViewModel.IdCategoria,
			DataAtualizacao = DateTime.Now
		};

		public static ProdutoListViewModel ToViewModel(this Produto produto) => new ProdutoListViewModel
		{
			Id = produto.Id,
			Titulo = produto.Titulo,
			Descricao = produto.Descricao,
			Preco = produto.Preco,
			Quantidade = produto.Quantidade,
			TituloCategoria = produto.Categoria.Titulo	
		};
	}
}