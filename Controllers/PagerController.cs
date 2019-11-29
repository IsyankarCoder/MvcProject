using Microsoft.AspNetCore.Mvc;

namespace MvcProject.Controllers {
   public class  PagerController:Controller
   {
        public PagerController()
        {

        }

        public IActionResult Index(int pn=1)
        {
           ViewBag.Paging =Set_Paging(pn,10,48,"activeLink", Url.Action("Index","Pager"),"disableLink");
           return View ();
        }

        public string Set_Paging(int PageNumber,int PageSize,int TotalRecords,string ClassName, string PageUrl,string DisableClassName)
        {
            string ReturnValue ="";
            return ReturnValue;
        }
   }
}