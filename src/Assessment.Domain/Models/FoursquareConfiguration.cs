namespace Assessment.Domain.Models
{
  public class FoursquareConfiguration
  {
    public string Uri { get; set; } = "https://api.foursquare.com/v2/venues/";
    public long Version { get; set; } = 20200509;
    public int Radius { get; set; } = 10000;
    public string Intent { get; set; } = "browse";
    public int limit { get; set; } = 10;
    public string CategoryId { get; set; }
  }
}