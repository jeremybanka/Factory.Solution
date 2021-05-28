using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Factory.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
  public class EngineersController : Controller
  {
    private readonly FactoryContext _db;

    public EngineersController(FactoryContext db)
    {
      _db = db;
    }

    public List<Engineer> AllEngineers() => _db.Engineers.ToList();
    public Engineer FindEngineer(string id) => _db.Engineers
      .Include(Engineer => Engineer.Licenses)
      .ThenInclude(license => license.Machine)
      .FirstOrDefault(Engineer => Engineer.EngineerId == id);

    public ActionResult Index() => View(AllEngineers());

    public ActionResult Create() => View();
    [HttpPost]
    public ActionResult Create(Engineer e)
    {
      _db.Engineers.Add(e);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(string id) => View(FindEngineer(id));

    public ActionResult Edit(string id, string controller)
    {
      ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Name");
      ViewBag.Controller = controller;
      return View(FindEngineer(id));
    }
    [HttpPost]
    public ActionResult Edit(Engineer m)
    {
      _db.Entry(m).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(string id) => View(FindEngineer(id));

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(string id)
    {
      _db.Engineers.Remove(FindEngineer(id));
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}