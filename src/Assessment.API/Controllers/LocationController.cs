using Assessment.Domain.Interfaces;
using Assessment.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Assessment.API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class LocationController : ControllerBase
  {
    private readonly ILocationService _locationService;
    public LocationController(ILocationService locationService)
    {
      _locationService = locationService;
    }

    [HttpGet("venues/{locationName}")]
    [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any)]
    public async Task<IActionResult> VenuesByNameAsync(string locationName)
    {
      var result = await _locationService.GetVenuesByNameAsync(locationName).ConfigureAwait(false);

      return Ok(result);
    }

    [HttpPost("venues")]
    [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any)]
    public async Task<IActionResult> VenuesByGPSCoordinatesAsync([FromBody] LocatiionCoordinates locatiionCoordinates)
    {
      var result = await _locationService.GetVenuesByGPSCoordinatesAsync(locatiionCoordinates).ConfigureAwait(false);

      return Ok(result);
    }

    [HttpGet("venues/{venueId}/venue/images")]
    [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any)]
    public async Task<IActionResult> VenueImagesAsync([Required] string venueId)
    {
      var result = await _locationService.GetVenueImagesAsync(venueId).ConfigureAwait(false);

      return Ok(result);
    }

    [HttpGet("venues/{photoId}/image/details")]
    [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any)]
    public async Task<IActionResult> ImageDetailsAsync([Required] string photoId)
    {
      var result = await _locationService.GetImageDetailsAsync(photoId).ConfigureAwait(false);

      return Ok(result);
    }
  }
}
