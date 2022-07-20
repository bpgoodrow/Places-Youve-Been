using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string Journal { get; set; }
    public string Photo {get; set;}
    public int Id { get; }
    private static List<Place> _instances = new List<Place> { };

    public Place(string cityName, string journal, string photo)
    {
      CityName = cityName;
      Journal = journal;
      Photo = photo;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}