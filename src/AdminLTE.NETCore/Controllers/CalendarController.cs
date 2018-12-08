using AdminLTE.NETCore.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace AdminLTE.NETCore.Controllers
{
    [DisplayOrder(7)]
    [DisplayImage("")]
    [TreeViewSettings("small|label pull-right bg-red|3", "small|label pull-right bg-blue|17")]
    public class CalendarController : Controller
    {
        [DisplayActionMenu]
        [DisplayImage("fa fa-calendar")]
        [ScriptAfterPartialView("/js/calendar.min.js")]
        [TreeView("", "label pull-right bg-red", "3")]
        public IActionResult Calendar(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }
    }
}