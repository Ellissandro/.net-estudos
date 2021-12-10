using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace curso.api.Filters
{
    public class ValidacaoModelStateCustomizado : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {

            }
        }
    }
}
