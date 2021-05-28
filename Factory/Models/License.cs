using System;


namespace Factory.Models
{
  public class License
  {
    public License()
    {
      LicenseId = Guid.NewGuid().ToString();
    }
    public string LicenseId { get; set; }
    public string EngineerId { get; set; }
    public string MachineId { get; set; }
    public virtual Engineer Engineer { get; set; }
    public virtual Machine Machine { get; set; }
  }
}