using System.Collections.Generic;

namespace Cars.Objects
{
  public class car
  {
  private string _MakeModel;
  private int _Price;
  private static List<car> _carList = new List<car> {};

  public car (string MakeModel, int Price)
  {
    _MakeModel = MakeModel;
    _Price = Price;
  }

  // car lexus = new car("lexus", 234234);
  public bool FitsBudget(int maxPrice)
  {
    return(_Price <= maxPrice);
  }
  // public void SetMakeModel(MakeModel)
  // {
  //   _MakeModel = MakeModel;
  // }
  // class Cd
  // {
  //   private string title;
  //   public Cd (string albumTitle)
  //   {
  //     title = albumTitle;
  //   }
  //   public void SetTitle (string newTitle)
  //   {
  //     title = newTitle;
  //   }
  // }

  // newCd.setTitle("hello");

  public string GetMakeModel()
  {
    return _MakeModel;
  }
  // public int SetPrice()
  // {
  //   _Price = Price;
  // }
  public int GetPrice()
  {
    return _Price;
  }
  public static List<car> GetAll()
  {
    return _carList;
  }
  public static void Save(car car)
  {
    _carList.Add(car);
  }

}
}
