using System;
using System.Collections.Generic;
using System.Linq;
using Data.DataContext;
using Microsoft.EntityFrameworkCore;
using VsCodeTesteApi.Models;

namespace VsCodeTesteApi.Repositories
{
	public class CategoriaRepositorio
	{
		private readonly DataContext _dataContext;

		public CategoriaRepositorio(DataContext dataContext) => this._dataContext = dataContext;

		public Categoria RecuperarCategoria(int id)
		{
			return this._dataContext.Categorias.Find(id);
		}

		public IEnumerable<Categoria> RecuperarCategorias()
		{
			return this._dataContext.Categorias
				.Include(c => c.Produtos)
				.AsNoTracking()
				.ToList();
		}

		public void CadastrarCategoria(Categoria categoria)
		{
			this._dataContext.Categorias.Add(categoria);
			this._dataContext.SaveChanges();
		}
	}
}