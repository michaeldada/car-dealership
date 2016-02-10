using Nancy;
using Cars.Objects;
using System.Collections.Generic;

namespace Cars
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        car porsche = new car("2014 Porsche 911", 114991);
        car.Save(porsche);

        car ford = new car("2011 Ford F450", 55995);
        car.Save(ford);

        car lexus = new car("2013 Lexus RX 350", 44700);
        car.Save(lexus);

        car mercedes = new car("Mercedes Benz CLS550", 39900);
        car.Save(mercedes);
        // Program.Main();
        List<car> carList = new List<car>{porsche, ford, lexus, mercedes};
        List<car> list = car.GetAll();
        return View["add_new_car.cshtml", carList];
      };
      Post["/car"] = _ => {
        int maxPrice = int.Parse(Request.Form["maxPrice"]);
      //  int maxMiles = int.Parse(Request.Form["maxMiles"]);
        List<string> returnCarsString = new List<string>{};
        List<car> allCars = car.GetAll();
        foreach (car automobile in allCars)
        {
          if (automobile.FitsBudget(maxPrice))
          {
            string carName = automobile.GetMakeModel();
            returnCarsString.Add(carName);
          }
        }
        return View["view_all_cars.cshtml", returnCarsString];
      };
    }
  }
}
