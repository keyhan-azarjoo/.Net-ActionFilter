using ActionFilterAttributeBaseSample.ActionFilters;
using ActionFilterAttributeBaseSample.Requests;
using Microsoft.AspNetCore.Mvc;

namespace ActionFilterAttributeBaseSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActionFilterAttributeTestController : Controller
    {

        [HttpPost]
        [ServiceFilter(typeof(LogActionFilter))]// You can have as many as Action Filter you like. This Filter logs the steps.
        public async Task<IActionResult> PostTaskAsync( MyRequest request , CancellationToken cancellationToken)
        {
            // Rest Of your Code
            await Task.CompletedTask;
            string result = "rigestered";
            return Ok(result);
        }


        [HttpGet]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(LogActionFilter))]// You can have as many as Action Filter you like
        public async Task<IActionResult> GetTaskAsync(Guid ID, string Name, CancellationToken cancellationToken)
        {
            // Rest Of Your Code
            await Task.CompletedTask;
            return Ok("Info");
        }

    }
}



