using Microsoft.AspNetCore.Mvc;

namespace PrincipalControlles.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        return View("Index");
    }
}