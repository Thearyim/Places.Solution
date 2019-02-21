using System.Collections.Generic;
using City.Models;

namespace Places.Models
{
  public class Place
  {
    private string _name;
    private CityClass _city;

    public Place (string name, CityClass city)
    {
      _name = name;
      _city = city;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetCityLengthOfStay()
    {
      return _city.GetLengthOfStay();
    }

    public string GetCityWhoWith()
    {
      return _city.GetWhoWith();
    }
  }
}
