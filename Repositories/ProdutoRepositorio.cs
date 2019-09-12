using System;
using System.Collections.Generic;
using Data.DataContext;
using VsCodeTesteApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using VsCodeTesteApi.Translate;
using VsCodeTesteApi.ViewModels.ProdutoViewModel;

namespace VsCodeTesteApi.Repositories
{
	public class ProdutoRepositorio
	{
		private readonly DataContext _dataContext;

		public ProdutoRepositorio(DataContext dataContext) => this._dataContext = dataContext;

		public Produto RecuperarProduto(int id)
		{
			return this._dataContext.Produtos.Find(id);
		}

		public IEnumerable<ProdutoListViewModel> RecuperarProdutos()
		{
			return this._dataContext.Produtos
				.Include(p => p.Categoria)
				.Select(p => p.ToViewModel())
				.AsNoTracking()
				.ToList();
		}

		public void CadastrarProduto(Produto produto)
		{
			this._dataContext.Produtos.Add(produto);
			this._dataContext.SaveChanges();
		}
	}
}