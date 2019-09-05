using System;
using System.Collections.Generic;
using Data.DataContext;
using VsCodeTesteApi.Models;

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

		public IEnumerable<Produto> RecuperarProdutos()
		{
			return this._dataContext.Produtos;
		}

		public void CadastrarProduto(Produto produto)
		{
			this._dataContext.Produtos.Add(produto);
			this._dataContext.SaveChanges();
		}
	}
}