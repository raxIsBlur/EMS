using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EMS.MultiTenancy.Dto;

namespace EMS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
