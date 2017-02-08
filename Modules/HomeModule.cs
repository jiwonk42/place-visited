using Nancy;
using VisitedPlaces.Objects
using System.Collections.Generic

namespace VisitedPlaces
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get["/place_form"] = _ => View["place_form.cshtml"];
    }
  }
}
