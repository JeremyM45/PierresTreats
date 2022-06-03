using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Collections.Generic;
using System.Linq;

namespace PierresTreats.Controllers
{
    public class HomeController : Controller
    {
      private readonly PierresTreatsContext _db;
      public HomeController(PierresTreatsContext db)
      {
        _db = db;
      }
      [HttpGet("/")]
      public ActionResult Index()
      {
        List<Treat> model = _db.Treats.ToList();
        ViewBag.Flavors = _db.Flavors.ToList();
        return View(model);
      }

    }
}