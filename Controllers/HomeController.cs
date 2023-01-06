using Microsoft.AspNetCore.Mvc;
using Sillystringz.Models;

namespace Sillystringz.Controllers
{
  public class HomeController : Controller
  {
    private readonly SillystringzContext _db;
    public HomeController(SillystringzContext db)
    {
      _db = db;
    }
    
    [HttpGet("/")]
    public ActionResult Index() {
      return View();
    }
  }
}