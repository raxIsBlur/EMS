using Abp.AspNetCore.Mvc.ViewComponents;

namespace EMS.Web.Views
{
    public abstract class EMSViewComponent : AbpViewComponent
    {
        protected EMSViewComponent()
        {
            LocalizationSourceName = EMSConsts.LocalizationSourceName;
        }
    }
}
