using Microsoft.AspNetCore.Mvc;
using Todo.Data;
using Todo.Models;

namespace Todo.Controller
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Get([FromServices] AppDbContext context)
            => Ok(context.Todos.ToList());
    }
}