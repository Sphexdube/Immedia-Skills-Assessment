using Assessment.Domain.Models;
using Assessment.Domain.Models.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Assessment.Domain.Interfaces
{
  public interface ILocationService
  {
    Task<IList<Venue>> GetVenuesByNameAsync(string locationName);
    Task<IList<Venue>> GetVenuesByGPSCoordinatesAsync(LocatiionCoordinates locatiionCoordinates);
    Task<Photos> GetVenueImagesAsync(string venueId);
    Task<Photo> GetImageDetailsAsync(string photoId);
  }
}