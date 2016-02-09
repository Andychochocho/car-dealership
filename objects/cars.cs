using System.Collections.Generic;
namespace CarDealership.Objects
{
  public class Cars
  {
    private string _makeModel;
    private int _price;
    private int _mileage;
    private static List<string> _makeModels = new List<string> {};
    private static List<int> _prices = new List<int> {};
    private static List<int> _mileages = new List<int> {};
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


    public static List<string> GetAllMakeModel()
    {
      return _makeModels;
    }
    public static List<int> GetAllPrice()
    {
      return _prices;
    }
    public static List<int> GetAllMileage()
    {
      return _mileages;
    }

    public void Save()
    {
      _makeModels.Add(_makeModel);
      _prices.Add(_price);
      _mileages.Add(_mileage);
    }
  }
}
