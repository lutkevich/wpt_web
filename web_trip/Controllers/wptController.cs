using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_trip.Models;

namespace web_trip.Controllers
{
    public class wptController : Controller
    {
        //
        // GET: /wpt_controller/
        private web_trip_dbEntities db = new web_trip_dbEntities();

        public ActionResult Index()
        {
                //из базы wpts выбираем все точки (все поля)
            var wpt1 = (from wpt in db.wpts select wpt ).ToList();
            return View(wpt1);
        }

    }
}
