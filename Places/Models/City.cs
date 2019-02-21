using System.Collections.Generic;

namespace City.Models
{
  public class CityClass
  {
    private string _lengthOfStay;
    private string _whoWith;

    public CityClass(string lengthOfStay, string whoWith)
    {
      _lengthOfStay = lengthOfStay;
      _whoWith = whoWith;
    }

    public string GetLengthOfStay()
    {
      return _lengthOfStay;
    }

    public void SetLengthOfStay(string newLengthOfStay)
    {
      _lengthOfStay = newLengthOfStay;
    }

    public string GetWhoWith()
    {
      return _whoWith;
    }

    public void SetWhoWith(string newWhoWith)
    {
      _whoWith = newWhoWith;
    }
  }
}
