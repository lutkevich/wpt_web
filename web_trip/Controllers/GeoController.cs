using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using ubs.GeoBazaAPI;

namespace web_trip.Controllers
{
    //public class GeoController : Controller
    //{
    //    //
    //    // GET: /Geo/

    //    public ActionResult Index()
    //    {
    //        return View();
    //    }

    //}



    public class GeoController : Controller
    {
        //private  coordinates;
         public ActionResult Index()
        {
            //// получаем ip клиента (если не локальный хост)
            //string IP = HttpContext.Request.UserHostAddress;
            string coordinates = "";
            //// получаем географию
            //ViewBag.Location=DefineLocation(IP, ref coordinates);
            coordinates = "55.788648" + ", " + "37.3761030";
            ViewBag.Coords = coordinates;
            return View();
        }
         
        //// определяем местоположение, обращаясь к API и базе данных
        //protected string DefineLocation(string IP, ref string coordinates)
        //{
        //    GeoBazaAPI geo = new GeoBazaAPI(Server.MapPath("~/BD/geobaza.dat"));
        //    string result = "Не определено";
        //    // получаем географию по ip
        //    List<IPLocation> locList = geo.GetLocationByIP(IP);
        //    if (locList != null && locList.Count != 0 && locList[0].ID != -1)
        //    {
        //        IPLocation country = GetCountry(locList);
                
        //        if (country != null)
        //            result = country.ISOID + ", " + country.NameRU + ", " + locList[0].NameRU + ", долгота: " + locList[0].Longitude + ", долгота: " + locList[0].Latitude;
        //        else
        //            result = locList[0].NameRU + ", долгота: " + locList[0].Longitude + ", долгота: " + locList[0].Latitude;
        //        coordinates = locList[0].Latitude + ", " + locList[0].Longitude;
        //    }
             
        //    return result;
        //}
        //// определяем страну
        //private IPLocation GetCountry(List<IPLocation> locList)
        //{
        //    for (int i = 0; i < locList.Count; i++)
        //    {
        //        if (locList[i].Type == LocationType.Country)
        //            return locList[i];
        //    }
        //    return null;
        //}
    }
}
