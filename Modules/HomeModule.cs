using Nancy;
using VisitedPlaces.Objects;
using System;
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
        Detail newDetail = new Detail(Request.Form["new-date"], Request.Form["new-occasion"], Request.Form["new-food"]);
        Place newPlace = new Place(Request.Form["new-place"],newDetail);
        List<Place> allPlace = Place.GetList();
        return View["places.cshtml", allPlace];
      };
      Get["/places/{number}"] = parameters => {
        Place numberedPlace = Place.Find(parameters.number);
        return View["/place.cshtml", numberedPlace];
      };
      Post["/place_cleared/{id}"] = parameters => {
        Place.ClearSingle(parameters.id);
        return View["/place_cleared.cshtml"];
      };
      Post["/places_cleared"] = _ => {
        Place.ClearAll();
        return View["/places_cleared.cshtml"];
      };
    }
  }
}
