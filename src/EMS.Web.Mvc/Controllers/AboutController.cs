using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using EMS.Controllers;

namespace EMS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : EMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
