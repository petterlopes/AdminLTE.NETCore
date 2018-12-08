using AdminLTE.NETCore.Attributes;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AdminLTE.NETCore.Controllers
{
    [DisplayOrder(10)]
    [DisplayImage("")]
    [TreeViewSettings("")]
    public class PhotoSwipeController : Controller
    {
        [DisplayActionMenu]
        [DisplayImage("fa fa-photo")]
        [ScriptAfterPartialView("/js/PhotoSwipe/photoswipe.min.js")]
        [TreeView("", "label pull-right bg-red", "3")]
        public IActionResult PhotoSwipe(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }
    }
}