using System;
using System.Collections.Generic;

namespace Workdo.Models
{
  public class NavModel
  {
    public string name { get; set; }

    public string link { get; set; }

    public string icon { get; set; }

    public bool active { get; set; }

    public List<NavModel> childs { get; set; }
  }
}