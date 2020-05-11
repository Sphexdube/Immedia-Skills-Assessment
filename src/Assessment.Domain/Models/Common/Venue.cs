﻿using System.Collections.Generic;

namespace Assessment.Domain.Models.Common
{
  public class Venue
  {
    public string id { get; set; }
    public string name { get; set; }
    public Contact contact { get; set; }
    public Location location { get; set; }
    public IList<Category> categories { get; set; }
    public bool verified { get; set; }
    public Stats stats { get; set; }
    public BeenHere beenHere { get; set; }
  }

  public class Contact
  {
  }
}
