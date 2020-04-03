using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ParkFinderClient.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public string DateEstablished { get; set; }
    public string Area { get; set; }
    public string Description { get; set; }
    

    public static List<Park> GetParks()
    {
      var apiCallTask = ParkApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Park> parkList = JsonConvert.DeserializeObject<List<Park>>(jsonResponse.ToString());

      return parkList;
    }

    public static Park GetDetails(int id)
    {
      var apiCallTask = ParkApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Park park = JsonConvert.DeserializeObject<Park>(jsonResponse.ToString());

      return park;
    }

    public static void Post(Park park)
    {
      string jsonPark = JsonConvert.SerializeObject(park);
      var apiCallTask = ParkApiHelper.Post(jsonPark);
    }

    public static void Put(Park park)
    {
      string jsonPark = JsonConvert.SerializeObject(park);
      var apiCallTask = ParkApiHelper.Put(park.ParkId, jsonPark);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ParkApiHelper.Delete(id);
    }
  }
}