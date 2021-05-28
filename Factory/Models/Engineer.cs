using System;
using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      EngineerId = Guid.NewGuid().ToString();
      Licenses = new HashSet<License>();
    }
    public string EngineerId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<License> Licenses { get; set; }
  }
}