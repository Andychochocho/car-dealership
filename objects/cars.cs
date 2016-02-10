using System.Collections.Generic;
namespace CarDealership.Objects
{
  public class Cars
  {
    private string _makeModel;
    private int _price;
    private int _mileage;
    private static List<Cars> _instances = new List<Cars>();

    public Cars (string MakeModel, int Price, int Mileage)
    {
      _makeModel = MakeModel;
      _price = Price;
      _mileage = Mileage;
    }
    public string GetMakeModel()
    {
      return _makeModel;
    }
    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }
    public int GetPrice()
    {
      return _price;
    }
    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    public int GetMileage()
    {
      return _mileage;
    }
    public void SetMileage(int newMileage)
    {
      _mileage = newMileage;
    }


    public static List<Cars> GetAllCars()
    {
      return _instances;
    }
    public void Save(Cars newCar)
    {
      _instances.Add(newCar);
    }
    public static void ClearAll()
   {
     _instances.Clear();
   }
  }
}
