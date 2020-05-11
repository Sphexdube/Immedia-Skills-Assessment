using System.Collections.Generic;

namespace Assessment.Domain.Models.Common
{
  public class Response
  {
    public IList<Venue> venues { get; set; }
    public bool confident { get; set; }
    public Photos photos { get; set; }
    public Photo photo { get; set; }
  }
}
