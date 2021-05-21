using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Salon.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Salon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly SalonContext _db;
    public ClientsController(SalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients.Include(client => client.Stylist).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(client => client.Id == id);
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View(thisClient);
    }

    // Add Edit route for further exploration
    // Add Edit route (POST) for further exploration
    // Add Delete route for further exploration
    // Add Delete route (POST) for further exploration
  }
}