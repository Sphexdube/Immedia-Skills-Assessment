using Assessment.Domain.Interfaces;
using Assessment.Domain.Models;
using Assessment.Domain.Models.Common;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.DataAccess
{
  public class DataService : IDataService
  {
    private readonly IMongoCollection<Venue> _venues;
    private readonly IMongoCollection<Photos> _photos;

    public DataService(DatabaseSettings databaseSettings)
    {
      var client = new MongoClient(databaseSettings.ConnectionString);
      var database = client.GetDatabase(databaseSettings.DatabaseName);

      _venues = database.GetCollection<Venue>(databaseSettings.VenuesCollectionName);
      _photos = database.GetCollection<Photos>(databaseSettings.PhotosCollectionName);
    }

    public Task SaveVenuesAsync(IList<Venue> venues)
    {
      var request = venues.Select(x => new InsertOneModel<Venue>(x));
      try
      {
        _venues.BulkWrite(request, new BulkWriteOptions() { IsOrdered = false });
      }
      catch (MongoBulkWriteException)
      {
        // Exception thrown when there are any duplicates
      }
      return Task.CompletedTask;
    }

    public Task SaveVenueImagesAsync(Photos photos) => _photos.InsertOneAsync(photos);
  }
}

