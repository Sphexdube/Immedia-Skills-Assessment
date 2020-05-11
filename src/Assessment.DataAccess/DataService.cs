using Assessment.Domain.Interfaces;
using Assessment.Domain.Models;
using Assessment.Domain.Models.Common;
using MongoDB.Driver;
using System.Collections.Generic;
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

    public Task SaveVenuesAsync(IList<Venue> venues) => _venues.InsertManyAsync(venues);

    public Task SaveVenueImagesAsync(Photos photos) => _photos.InsertOneAsync(photos);
  }
}

