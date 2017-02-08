using System;
using System.Collections.Generic;

namespace VisitedPlaces.Objects
{
  public class Place
  {
    private string _name;
    private int _id;
    private Detail _detail;

    private static List<Place> _myList = new List<Place>{};
    private static int idCounter = 1;


    public Place (string name, Detail detail)
    {
      _name = name;
      _detail = detail;
      _id = idCounter;
      idCounter++;
      _myList.Add(this);
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public int GetId()
    {
      return _id;
    }

    public Detail GetDetail()
    {
      return _detail;
    }

    public void SetDetail(Detail newDetail)
    {
      _detail = newDetail;
    }

    public static List<Place> GetList()
    {
      return _myList;
    }

    public static Place Find(int searchNo)
    {
      return _myList[searchNo - 1];
    }

    public static void ClearSingle(int searchNoSingle)
    {
      _myList.RemoveAt(searchNoSingle - 1);
    }

    public static void ClearAll()
    {
      _myList.Clear();
    }

  }
}
