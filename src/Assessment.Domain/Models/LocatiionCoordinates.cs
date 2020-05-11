using System;

namespace Assessment.Domain.Models
{
  public class LocatiionCoordinates
  {
    private double _longitude;
    private double _latitude;

    public double Latitude 
    {
      get
      {
        return this._latitude;
      }
      set
      {
        if (value < -90 || value > 90)
        {
          throw new ArgumentOutOfRangeException("Latitude must be between -90 and 90 degrees inclusive.");
        }
        this._latitude = value;
      }
    }
    public double Longitude 
    {
      get
      {
        return this._longitude;
      }
      set
      {
        if (value < -180 || value > 180)
        {
          throw new ArgumentOutOfRangeException("Longitude must be between -180 and 180 degrees inclusive.");
        }
        this._longitude = value;
      }
    }
  }
}