using Nancy;
using CarDealership.Objects;
using System.Collections.Generic;

namespace CarDealership
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_cars.cshtml"];
      Get["/view_all_cars"] = _ => {
       List<Cars> _allCars = Cars.GetAllCars();
        return View["view_all_cars.cshtml", _allCars];
      };
      Post["/cars_added"] = _ => {
      Cars newCar = new Cars (Request.Form["make-model"], Request.Form["price"], Request.Form["mileage"]);
        newCar.Save(newCar);
        return View["cars_added.cshtml", newCar];
      };
      Post["/cars_cleared"] = _ => {
        Cars.ClearAll();
        return View["cars_cleared.cshtml"];
      };
    }
  }
}
