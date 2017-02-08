using System;
using System.Collections.Generic;

namespace VisitedPlaces.Objects
{
  public class Place
  {
    private string _name;
    private int _number;

    private static List<Place> _myList = new List<Place>{};


    public Place (string name)
    {
      _name = name;
      _myList.Add(this);
      _number = _myList.Count;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public int GetNumber()
    {
      return _number;
    }

    public void SetNumber(int newNumber)
    {
      _number = newNumber;
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
