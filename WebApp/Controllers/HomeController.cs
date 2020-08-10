using Microsoft.AspNetCore.Mvc;
using Persistence_Layer.Data;
using System.Linq;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        private DataContext context;
        public HomeController(DataContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return View(context.Groups.First());
        }
    }
}
