using System;
using Microsoft.AspNetCore.Mvc;

namespace MvcProject.Controllers {
   public class PagerController : Controller {
      public PagerController () {

      }

      public IActionResult Index (int pn = 1) {
         ViewBag.Paging = Set_Paging (pn, 10, 48, "activeLink", Url.Action ("Index", "Pager"), "disableLink");
         return View ();
      }

      public string Set_Paging (int PageNumber, int PageSize, Int64 TotalRecords, string ClassName, string PageUrl, string DisableClassName) {
         string ReturnValue = "";
         try {
            Int64 TotalPages = Convert.ToInt64 (Math.Ceiling ((double) TotalRecords / PageSize));
            if (PageNumber > 1) {
               if (PageNumber == 2)
                  ReturnValue = ReturnValue + "<a href='" + PageUrl.Trim () + "?pn=" + Convert.ToString (PageNumber - 1) + "' class='" + ClassName + "'>Previous</a>   ";
               else {
                  ReturnValue = ReturnValue + "<a href='" + PageUrl.Trim ();
                  if (PageUrl.Contains ("?"))
                     ReturnValue = ReturnValue + "&";
                  else
                     ReturnValue = ReturnValue + "?";
                  ReturnValue = ReturnValue + "pn=" + Convert.ToString (PageNumber - 1) + "' class='" + ClassName + "'>Previous</a>   ";
               }
            } else
               ReturnValue = ReturnValue + "<span class='" + DisableClassName + "'>Previous</span>   ";
            if ((PageNumber - 3) > 1)
               ReturnValue = ReturnValue + "<a href='" + PageUrl.Trim () + "' class='" + ClassName + "'>1</a> ..... | ";
            for (int i = PageNumber - 3; i <= PageNumber; i++)
               if (i >= 1) {
                  if (PageNumber != i) {
                     ReturnValue = ReturnValue + "<a href='" + PageUrl.Trim ();
                     if (PageUrl.Contains ("?"))
                        ReturnValue = ReturnValue + "&";
                     else
                        ReturnValue = ReturnValue + "?";
                     ReturnValue = ReturnValue + "pn=" + i.ToString () + "' class='" + ClassName + "'>" + i.ToString () + "</a> | ";
                  } else {
                     ReturnValue = ReturnValue + "<span style='font-weight:bold;'>" + i + "</span> | ";
                  }
               }
            for (int i = PageNumber + 1; i <= PageNumber + 3; i++)
               if (i <= TotalPages) {
                  if (PageNumber != i) {
                     ReturnValue = ReturnValue + "<a href='" + PageUrl.Trim ();
                     if (PageUrl.Contains ("?"))
                        ReturnValue = ReturnValue + "&";
                     else
                        ReturnValue = ReturnValue + "?";
                     ReturnValue = ReturnValue + "pn=" + i.ToString () + "' class='" + ClassName + "'>" + i.ToString () + "</a> | ";
                  } else {
                     ReturnValue = ReturnValue + "<span style='font-weight:bold;'>" + i + "</span> | ";
                  }
               }
            if ((PageNumber + 3) < TotalPages) {
               ReturnValue = ReturnValue + "..... <a href='" + PageUrl.Trim ();
               if (PageUrl.Contains ("?"))
                  ReturnValue = ReturnValue + "&";
               else
                  ReturnValue = ReturnValue + "?";
               ReturnValue = ReturnValue + "pn=" + TotalPages.ToString () + "' class='" + ClassName + "'>" + TotalPages.ToString () + "</a>";
            }
            if (PageNumber < TotalPages) {
               ReturnValue = ReturnValue + "   <a href='" + PageUrl.Trim ();
               if (PageUrl.Contains ("?"))
                  ReturnValue = ReturnValue + "&";
               else
                  ReturnValue = ReturnValue + "?";
               ReturnValue = ReturnValue + "pn=" + Convert.ToString (PageNumber + 1) + "' class='" + ClassName + "'>Next</a>";
            } else
               ReturnValue = ReturnValue + "   <span class='" + DisableClassName + "'>Next</span>";
         } catch (Exception ex) { }
         return (ReturnValue);
      }
   }
}