using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilterAttributeBaseSample.ActionFilters
{
    public class ValidationFilterAttribute : IActionFilter
    {

        // This class execute befor hiting the controller and we Used Action filter to filter our requests
        // For running this class we need to inject it to Configuration in Program.cs or Startup.cs
        public void OnActionExecuting(ActionExecutingContext contex) // It execute before going to controller in this project
        {
            var ID = contex.ActionArguments.SingleOrDefault(p => p.Key is "ID"); // we check that is Id parameter Guid or no
            if (ID.Value is null || ID.Value is not Guid)
            {
                contex.Result = new BadRequestObjectResult("Id should be Guid");
                return;
            }
            var Name = contex.ActionArguments.SingleOrDefault(p => p.Key is "Name"); // we check that is Name equal to keyhan or no
            if (Name.Value is not "keyhan")
            {
                contex.Result = new BadRequestObjectResult("Name should be keyhan");
                return;
            }
            if (!contex.ModelState.IsValid)
            {
                contex.Result = new BadRequestObjectResult(contex.ModelState);
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // This is just an example how you can manipulate the result.
            var StatusCode = context.HttpContext.Response.StatusCode;
            if (StatusCode != 200)
            {
                context.Result = new BadRequestObjectResult("There is a problem. Please try again later");
            }

        }
    }
}
