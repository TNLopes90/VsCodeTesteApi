using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VsCodeTesteApi.Models;
using VsCodeTesteApi.Repositories;

namespace VsCodeTesteApi.Controllers
{
	public class CategoriaController : Controller
	{
		private readonly CategoriaRepositorio _categoriaRepositorio;

		public CategoriaController(CategoriaRepositorio categoriaRepositorio) => this._categoriaRepositorio = categoriaRepositorio;

		[Route("CategoriaController/categoria")]
		[HttpGet]
		public IEnumerable<Categoria> Get()
		{
			return this._categoriaRepositorio.RecuperarCategorias();
		}

		[Route("CategoriaController/categoria/{id}")]
		[HttpGet]
		public Categoria Get(int id)
		{
			return this._categoriaRepositorio.RecuperarCategoria(id);
		}

		[HttpPost]
		[Route("CategoriaController/categoria")]
		public void Post([FromBody]Categoria categoria) => this._categoriaRepositorio.CadastrarCategoria(categoria);

	}
}