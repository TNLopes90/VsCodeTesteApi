using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VsCodeTesteApi.Models;
using VsCodeTesteApi.Repositories;
using VsCodeTesteApi.Translate;
using VsCodeTesteApi.ViewModels;
using VsCodeTesteApi.ViewModels.ProdutoViewModel;

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
		[Route("v1/ProdutoController/produtos")]
		public void Post([FromBody]Produto produto)
		{
			produto.DataAtualizacao = DateTime.Now;
			produto.DataCriacao = DateTime.Now;
			this._produtoRepositorio.CadastrarProduto(produto);
		}

		[HttpPost]
		[Route("v2/ProdutoController/produtos")]
		public ResultadoViewModel Post([FromBody]ProdutoEditViewModel produtoEditViewModel)
		{
			produtoEditViewModel.Validate();
			if(!produtoEditViewModel.Valid)
				return new ResultadoViewModel().CreateResultadoViewModel(false, "Não foi possível cadastrar o produto!", produtoEditViewModel.Notifications);
				
			this._produtoRepositorio.CadastrarProduto(produtoEditViewModel.ToModel());
			return new ResultadoViewModel().CreateResultadoViewModel(true, "Produto cadastrado com sucesso!", produtoEditViewModel);
		}
	}
}