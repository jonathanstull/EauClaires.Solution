using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salon.Models;
using System.Collections.Generic;
using System.Linq;

namespace Salon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly SalonContext _db;
    public StylistsController(SalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.Id == id);
      return View(thisStylist);
    }

    // Add Edit route for further exploration
    // Add Edit route (POST) for further exploration
    // Add Delete route for further exploration
    // Add Delete route (POST) for further exploration
  }
}