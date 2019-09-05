namespace VsCodeTesteApi.ViewModels
{
	public class ResultadoViewModel
	{
		public bool Sucesso { get; set; }
		public string Mensagem { get; set; }
		public object Data { get; set; }

		public ResultadoViewModel CreateResultadoViewModel<T>(bool sucesso, string mensagem, T t)
		{
			return new ResultadoViewModel
			{
				Sucesso = sucesso,
				Mensagem = mensagem,
				Data = t
			};
		}
	}
}