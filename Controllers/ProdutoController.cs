using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VsCodeTesteApi.Models;
using VsCodeTesteApi.Repositories;

namespace VsCodeTesteApi.Controllers
{
	public class ProdutoController
	{
		private readonly ProdutoRepositorio _produtoRepositorio;
		public ProdutoController(ProdutoRepositorio produtoRepositorio) => this._produtoRepositorio = produtoRepositorio;

		[HttpGet]
		[Route("ProdutoController/produtos")]
		public IEnumerable<Produto> Get()
		{
			return this._produtoRepositorio.RecuperarProdutos();
		}

		[HttpGet]
		[Route("ProdutoController/produtos/{id}")]
		public Produto Get(int id)
		{
			return this._produtoRepositorio.RecuperarProduto(id);
		}

		[HttpPost]
		[Route("ProdutoController/produtos")]
		public void Post([FromBody]Produto produto)
		{
			produto.DataAtualizacao = DateTime.Now;
			produto.DataCriacao = DateTime.Now;
			this._produtoRepositorio.CadastrarProduto(produto);
		}
	}
}