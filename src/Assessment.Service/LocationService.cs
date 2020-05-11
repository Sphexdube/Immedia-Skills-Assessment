using Assessment.Domain.Interfaces;
using Assessment.Domain.Models;
using Assessment.Domain.Models.Common;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Assessment.Service
{
  public class LocationService : ILocationService
  {
    private string clientId;
    private string clientSecret;
    private string uri;
    private long version;
    private int radius;
    private string intent;
    private int limit;
    private string categoryId;

    private readonly HttpClient _httpClient;
    private readonly FoursquareCredentials _foursquareCredentials;
    private readonly FoursquareConfiguration _foursquareConfig;
    private readonly IDataService _dataService;

    public LocationService(
      HttpClient httpClient,
      FoursquareCredentials foursquareCredentials,
      FoursquareConfiguration foursquareConfig,
      IDataService dataService)
    {
      _httpClient = httpClient;
      _foursquareCredentials = foursquareCredentials;
      _foursquareConfig = foursquareConfig;
      _dataService = dataService;

      clientId = _foursquareCredentials.ClientId;
      clientSecret = _foursquareCredentials.ClientSecret;

      uri = _foursquareConfig.Uri;
      version = _foursquareConfig.Version;
      radius = _foursquareConfig.Radius;
      intent = _foursquareConfig.Intent;
      limit = _foursquareConfig.limit;
      categoryId = _foursquareConfig.CategoryId;
    }

    public async Task<IList<Venue>> GetVenuesByNameAsync(string locationName)
    {

      var requestUri = $"{uri}/venues/search?client_id={clientId}&client_secret={clientSecret}&v={version}&near={locationName}&intent={intent}&radius={radius}&limit={limit}&categoryId={categoryId}";

      try
      {
        using (var httpResponse = await _httpClient.GetAsync(requestUri).ConfigureAwait(false))
        {
          var contentString = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
          var json = JsonConvert.DeserializeObject<FoursquareVenueResponse>(contentString);
          var venues = json.response.venues;
          if (venues != null)
          {
            await _dataService.SaveVenuesAsync(venues).ConfigureAwait(false);
          }
          return venues;
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public async Task<IList<Venue>> GetVenuesByGPSCoordinatesAsync(LocatiionCoordinates locatiionCoordinates)
    {
      var requestUri = $"{uri}/venues/search?client_id={clientId}&client_secret={clientSecret}&v={version}&ll={locatiionCoordinates.Latitude},{locatiionCoordinates.Longitude}&limit={limit}&categoryId={categoryId}";

      try
      {
        using (var httpResponse = await _httpClient.GetAsync(requestUri).ConfigureAwait(false))
        {
          var contentString = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
          var json = JsonConvert.DeserializeObject<FoursquareVenueResponse>(contentString);
          var venues = json.response.venues;
          if (venues != null)
          {
            await _dataService.SaveVenuesAsync(venues).ConfigureAwait(false);
          }
          return venues;
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public async Task<Photos> GetVenueImagesAsync(string venueId)
    {
      var requestUri = $"{uri}/venues/{venueId}/photos?client_id={clientId}&client_secret={clientSecret}&v={version}&group=venue&limit={limit}";

      try
      {
        using (var httpResponse = await _httpClient.GetAsync(requestUri).ConfigureAwait(false))
        {
          var contentString = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
          var json = JsonConvert.DeserializeObject<FoursquarePhotoResponse>(contentString);
          var photos = json.response.photos;
          if (photos != null)
          {
            await _dataService.SaveVenueImagesAsync(photos).ConfigureAwait(false);
          }
          return photos;
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public async Task<Photo> GetImageDetailsAsync(string photoId)
    {
      var requestUri = $"{uri}/photos/{photoId}?client_id={clientId}&client_secret={clientSecret}&v={version}";

      try
      {
        using (var httpResponse = await _httpClient.GetAsync(requestUri).ConfigureAwait(false))
        {
          var contentString = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
          var json = JsonConvert.DeserializeObject<PhotoDetailsResponse>(contentString);

          return json.response.photo;
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}


