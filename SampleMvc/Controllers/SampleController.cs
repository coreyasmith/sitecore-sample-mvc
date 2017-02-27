using System;
using System.Web.Mvc;
using SampleMvc.Models;

namespace SampleMvc.Controllers
{
  public class SampleController : Controller
  {
    public ActionResult SampleMvcInnerSublayout()
    {
      var model = new SampleMvcInnerSublayoutViewModel
      {
        CurrentYear = Sitecore.DateUtil.ToServerTime(DateTime.UtcNow).Year
      };

      return View(model);
    }
  }
}
