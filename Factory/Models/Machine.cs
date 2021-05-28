using System;
using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      MachineId = Guid.NewGuid().ToString();
      Licenses = new HashSet<License>();
    }
    public string MachineId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<License> Licenses { get; set; }
  }
}