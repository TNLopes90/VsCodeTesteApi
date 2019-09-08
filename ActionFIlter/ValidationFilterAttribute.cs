using System.Linq;
using Flunt.Notifications;
using Flunt.Validations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using VsCodeTesteApi.ViewModels;

namespace VsCodeTesteApi.ActionFilter
{
	public class ValidationFilterAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			PadraoViewModel padraoViewModel = (PadraoViewModel)context.ActionArguments.Values.Where(c => c is PadraoViewModel).FirstOrDefault();
			padraoViewModel.Validate();
			if(!padraoViewModel.Valid)
				context.Result = new BadRequestObjectResult(new ResultadoViewModel().CreateResultadoViewModel(false, "Não foi possível realizar a operação!", padraoViewModel.Notifications));
		}
	}
}