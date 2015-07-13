using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace inzSNM.Controllers
{
    public class SkladAnkietyController : Controller
    {
        // GET: SkladAnkiety
        public ActionResult Index()
        {

            var list = new SelectList(new[]
                                          {
                                              new{ID="1",Name="1"},
                                              new{ID="2",Name="2"},
                                              new{ID="3",Name="3"},
                                              new{ID="4",Name="4"},
                                              new{ID="5",Name="5"},
                                              new{ID="6",Name="6"},
                                              new{ID="7",Name="7"},
                                              new{ID="8",Name="8"},
                                              new{ID="9",Name="9"},
                                              new{ID="10",Name="10"},
                                          },
                             "ID", "Name", 1);
            ViewData["list"] = list;

          
                return View();

        }
   
    }
}