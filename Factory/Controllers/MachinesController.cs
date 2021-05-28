using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Factory.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly FactoryContext _db;

    public MachinesController(FactoryContext db)
    {
      _db = db;
    }

    public List<Machine> AllMachines() => _db.Machines.ToList();
    public Machine FindMachine(string id) => _db.Machines
      .Include(Machine => Machine.Licenses)
      .ThenInclude(license => license.Engineer)
      .FirstOrDefault(Machine => Machine.MachineId == id);

    public ActionResult Index() => View(AllMachines());

    public ActionResult Create() => View();
    [HttpPost]
    public ActionResult Create(Machine m)
    {
      _db.Machines.Add(m);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(string id) => View(FindMachine(id));

    public ActionResult Edit(string id, string controller)
    {
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
      ViewBag.Controller = controller;
      return View(FindMachine(id));
    }
    [HttpPost]
    public ActionResult Edit(Machine m)
    {
      _db.Entry(m).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(string id) => View(FindMachine(id));

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(string id)
    {
      _db.Machines.Remove(FindMachine(id));
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}