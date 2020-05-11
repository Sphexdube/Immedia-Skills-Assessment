using Assessment.Domain.Models.Common;
using System.Collections.Generic;

namespace Assessment.Domain.Models
{
  public class FoursquarePhotoResponse
  {
    public Meta meta { get; set; }
    public Response response { get; set; }
  }

  public class Checkin
  {
    public string id { get; set; }
    public int createdAt { get; set; }
    public string type { get; set; }
    public int timeZoneOffset { get; set; }
  }

  public class Item
  {
    public string id { get; set; }
    public int createdAt { get; set; }
    public Source source { get; set; }
    public string prefix { get; set; }
    public string suffix { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public User user { get; set; }
    public Checkin checkin { get; set; }
    public string visibility { get; set; }
  }

  public class Photos
  {
    public int count { get; set; }
    public IList<Item> items { get; set; }
    public int dupesRemoved { get; set; }
  }
}
