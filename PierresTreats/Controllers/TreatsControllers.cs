using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace TreatsController.Controllers
{
  public class TreatsController : Controller
  {
    private readonly PierresTreatsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public TreatsController(UserManager<ApplicationUser> userManager, PierresTreatsContext db)
    {
      _userManager = userManager;
      _db = db;
    }
    public ActionResult Index()
    {
      List<Treat> model = _db.Treats.ToList();
      return View(model);
    }
    public ActionResult Details(int id)
    {
      var thisTreat = _db.Treats.Include(t => t.JoinEntities).ThenInclude(join => join.Flavor).FirstOrDefault(t => t.TreatId == id);
      return View(thisTreat);
    } 
    // [Authorize]
    public ActionResult Create()
    {
      ViewBag.CategoryId = new SelectList(_db.Flavors, "CategoryId", "Name");
      return View();
    }
    [HttpPost]
    public ActionResult Create(Treat treat)
    {
      _db.Treats.Add(treat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}