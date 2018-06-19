using Microsoft.AspNetCore.Antiforgery;
using EMS.Controllers;

namespace EMS.Web.Host.Controllers
{
    public class AntiForgeryController : EMSControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
