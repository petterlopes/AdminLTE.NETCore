using AdminLTE.NETCore.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace AdminLTE.NETCore.Controllers
{
    [DisplayOrder(6)]
    [DisplayImage("fa fa-table")]
    [TreeView("i", "fa fa-angle-left pull-right", "")]
    public class TablesController : Controller
    {
        [DisplayActionMenu]
        [DisplayImage("fa fa-circle-o")]
        [ScriptAfterPartialView("")]
        public IActionResult SimpleTables(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }

        [DisplayActionMenu]
        [DisplayImage("fa fa-circle-o")]
        [ScriptAfterPartialView("/js/Tables/datatables.min.js")]
        public IActionResult DataTables(bool partial = false)
        {
            if (partial)
                return PartialView();
            else
                return View();
        }
    }
}