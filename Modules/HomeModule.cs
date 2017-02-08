using Nancy;
using VisitedPlaces.Objects;
using System.Collections.Generic;

namespace VisitedPlaces
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get["/places"] = _ => {
        List<Place> allPlace = Place.GetList();
        return View["places.cshtml", allPlace];
      };
      Get["/place_form"] = _ => View["place_form.cshtml"];
      Post["/places"] = _ => {
        Place newPlace = new Place(Request.Form["new-place"]);
        List<Place> allPlace = Place.GetList();
        return View["places.cshtml", allPlace];
      };
      Get["/places/{number}"] = parameters => {
        Place numberedPlace = Place.Find(parameters.number);
        return View["/place.cshtml", numberedPlace];
      };
    }
  }
}
