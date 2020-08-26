using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.Linq;

namespace Ecom.API.Attributes
{
    public class ValidateFilterAttribute : ResultFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            base.OnResultExecuting(context);

            //model valid not pass
            if (!context.ModelState.IsValid)
            {
                var validateObject = context.ModelState.Where(x => x.Value.Errors.Any()).Select(error =>
                {
                    return new
                    {
                        param = error.Key,
                        message = error.Value.Errors.Any() ? (error.Value.Errors[0].ErrorMessage == "" ? error.Value.Errors[0].Exception?.Message : error.Value.Errors[0].ErrorMessage) : "Validation failed"
                    };
                });

                context.Result = new ContentResult()
                {
                    Content = JsonConvert.SerializeObject(validateObject),
                    StatusCode = 412
                };
            }
        }
    }
}
