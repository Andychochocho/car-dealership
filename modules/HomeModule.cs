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
        List<string> allMakeModel = Cars.GetAllMakeModel();
        List<int> allPrice = Cars.GetAllPrice();
        List<int> allMileage = Cars.GetAllMileage();
        return View["view_all_cars.cshtml", allMakeModel];
      };
      Post["/cars_added"] = _ => {
      Cars newCar = new Cars (Request.Form["make-model"], Request.Form["price"], Request.Form["mileage"]);
        newCar.Save();
        return View["cars_added.cshtml", newCar];
      };
    }
  }
}
