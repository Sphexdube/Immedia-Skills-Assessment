using Assessment.Domain.Models;
using Assessment.Domain.Models.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Assessment.Domain.Interfaces
{
  public interface IDataService
  {
    Task SaveVenuesAsync(IList<Venue> venues);
    Task SaveVenueImagesAsync(Photos photos);
  }
}
