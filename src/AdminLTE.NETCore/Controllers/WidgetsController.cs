using AdminLTE.NETCore.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace AdminLTE.NETCore.Controllers
{
    [DisplayOrder(2)]
    [DisplayImage("")]
    [TreeViewSettings("small|label pull-right bg-green|new")]
    public class WidgetsController : Controller
    {
        [DisplayActionMenu]
        [DisplayImage("fa fa-th")]
        [ScriptAfterPartialView("")]
        //[TreeView("", "label pull-right bg-green", "new")]
        public IActionResult Widgets(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }
    }
}