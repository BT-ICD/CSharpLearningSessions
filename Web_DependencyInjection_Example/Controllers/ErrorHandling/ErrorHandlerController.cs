using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

//https://learn.microsoft.com/en-us/aspnet/core/fundamentals/error-handling?view=aspnetcore-7.0
namespace Web_DependencyInjection_Example.Controllers.ErrorHandling
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorHandlerController : ControllerBase
    {
        private readonly IHostEnvironment hostEnvironment;

        public ErrorHandlerController(IHostEnvironment hostEnvironment)
        {
            this.hostEnvironment = hostEnvironment;
        }
        [Route("/error")]
        public IActionResult HandleError()
        {
            return Problem();
        }

        [Route("/error-development")]
        public IActionResult HandleErrorDevelopment()
        {
            if (!hostEnvironment.IsDevelopment())
            {
                return NotFound();
            }
            
            var exceptionHandleFeture = HttpContext.Features.Get<IExceptionHandlerFeature>()!;
            return Problem(detail: exceptionHandleFeture.Error.StackTrace, title: exceptionHandleFeture.Error.Message+"Custom");
        }
     }
}
