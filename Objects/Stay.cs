namespace VisitedPlaces.Objects
{
  public class Detail
  {
    private string _date;
    private string _occasion;
    private string _food;

    public Detail(string date, string occasion, string food)
    {
      _date = date;
      _occasion = occasion;
      _food = food;
    }

    public void SetDate(string inputDate)
    {
      _date = inputDate;
    }

    public string GetDate()
    {
      return _date;
    }

    public void SetOccasion(string inputOccasion)
    {
      _occasion = inputOccasion;
    }

    public string GetOccasion()
    {
      return _occasion;
    }

    public void SetFood(string inputFood)
    {
      _food = inputFood;
    }

    public string GetFood()
    {
      return _food;
    }
  }
}
