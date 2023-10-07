using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients.ToList();
      return View(model);
    }

    public ActionResult Creat()
    {
      return view();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}