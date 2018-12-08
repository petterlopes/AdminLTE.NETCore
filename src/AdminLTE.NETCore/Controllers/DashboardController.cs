using AdminLTE.NETCore.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace AdminLTE.NETCore.Controllers
{
    [DisplayOrder(0)]
    [DisplayImage("fa fa-dashboard")]
    [TreeView("i", "fa fa-angle-left pull-right", "")]
    public class DashboardController : Controller
    {
        [DisplayActionMenu]
        [DisplayImage("fa fa-circle-o")]
        [ScriptAfterPartialView("/lib/AdminLTE-2.3.11/dist/js/pages/dashboard.min.js")]
        public IActionResult Dashboardv1(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenu]
        [DisplayImage("fa fa-circle-o")]
        //[ScriptAfterPartialView("/lib/AdminLTE-2.3.11/plugins/chartjs/Chart.min.js,/lib/AdminLTE-2.3.11/dist/js/pages/dashboard2.js")]
        [ScriptAfterPartialView("/lib/AdminLTE-2.3.11/dist/js/pages/dashboard2.min.js")]
        public IActionResult Dashboardv2(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }
    }
}