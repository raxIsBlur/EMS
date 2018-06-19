using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace EMS.Web.Views
{
    public abstract class EMSRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected EMSRazorPage()
        {
            LocalizationSourceName = EMSConsts.LocalizationSourceName;
        }
    }
}
