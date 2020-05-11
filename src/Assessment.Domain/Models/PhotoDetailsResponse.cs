using Assessment.Domain.Models.Common;

namespace Assessment.Domain.Models
{
  public class PhotoDetailsResponse
  {
    public Meta meta { get; set; }
    public Response response { get; set; }
  }

  public class Stats
  {
    public int tipCount { get; set; }
    public int usersCount { get; set; }
    public int checkinsCount { get; set; }
    public int visitsCount { get; set; }
  }

  public class BeenHere
  {
    public int count { get; set; }
    public int lastCheckinExpiredAt { get; set; }
    public bool marked { get; set; }
    public int unconfirmedCount { get; set; }
  }
}
