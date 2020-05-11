using System.Collections.Generic;

namespace Assessment.Domain.Models.Common
{
  public class Location
  {
    public string address { get; set; }
    public double lat { get; set; }
    public double lng { get; set; }
    public IList<LabeledLatLng> labeledLatLngs { get; set; }
    public string postalCode { get; set; }
    public string cc { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string country { get; set; }
    public IList<string> formattedAddress { get; set; }
  }
}
