using AdminLTE.NETCore.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace AdminLTE.NETCore.Controllers
{
    [DisplayOrder(3)]
    [DisplayImage("fa fa-pie-chart")]
    [TreeView("i", "fa fa-angle-left pull-right", "")]
    public class ChartsController : Controller
    {
        [DisplayActionMenu]
        [DisplayImage("fa fa-circle-o")]
        [ScriptAfterPartialView("/js/chartjs.min.js")]
        public IActionResult ChartJS(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenu]
        [DisplayImage("fa fa-circle-o")]
        [ScriptAfterPartialView("/js/morris.min.js")]
        public IActionResult Morris(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenu]
        [DisplayImage("fa fa-circle-o")]
        [ScriptAfterPartialView("/js/flot.min.js")]
        public IActionResult Flot(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenu]
        [DisplayImage("fa fa-circle-o")]
        [ScriptAfterPartialView("/js/inline.min.js")]
        public IActionResult InlineCharts(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }
    }
}