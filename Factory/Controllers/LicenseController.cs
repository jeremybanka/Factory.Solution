using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Factory.Models;

namespace Factory.Controllers
{
  public class LicensesController : Controller
  {
    private readonly FactoryContext _db;

    public LicensesController(FactoryContext db)
    {
      _db = db;
    }
    public License FindLicense(string id) => _db.Licenses
      .FirstOrDefault(e => e.LicenseId == id);

    public License CheckLicense(string MachineId, string EngineerId)
    {
      var maybeLicense = _db.Licenses
        .FirstOrDefault(e => e.EngineerId == EngineerId && e.MachineId == MachineId);
      return maybeLicense;
    }

    public void CreateNewLicense(string MachineId, string EngineerId)
    {
      _db.Licenses.Add(new License() { MachineId = MachineId, EngineerId = EngineerId });
      _db.SaveChanges();
    }


    [HttpPost]
    public ActionResult Delete(string id, string origin)
    {
      var e = FindLicense(id);
      _db.Licenses.Remove(e);
      _db.SaveChanges();
      string entityId = "";
      if (origin == "Machines") entityId = e.MachineId;
      if (origin == "Engineers") entityId = e.EngineerId;

      return RedirectToAction("Edit", origin, new { id = entityId });
    }

    [HttpPost]
    public ActionResult Create(string EngineerId, string MachineId, string origin)
    {
      bool EngineerIsNotLicensed = CheckLicense(MachineId, EngineerId) == null;
      if (MachineId != "" && EngineerIsNotLicensed)
      {
        CreateNewLicense(MachineId, EngineerId);
      }
      string entityId = "";
      if (origin == "Machines") entityId = MachineId;
      if (origin == "Engineers") entityId = EngineerId;

      return RedirectToAction("Edit", origin, new { id = entityId });
    }
  }
}