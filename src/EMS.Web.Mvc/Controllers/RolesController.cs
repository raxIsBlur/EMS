using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using EMS.Authorization;
using EMS.Controllers;
using EMS.Roles;
using EMS.Web.Models.Roles;

namespace EMS.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class RolesController : EMSControllerBase
    {
        private readonly IRoleAppService _roleAppService;

        public RolesController(IRoleAppService roleAppService)
        {
            _roleAppService = roleAppService;
        }

        public async Task<IActionResult> Index()
        {
            var roles = (await _roleAppService.GetAll(new PagedAndSortedResultRequestDto())).Items;
            var permissions = (await _roleAppService.GetAllPermissions()).Items;
            var model = new RoleListViewModel
            {
                Roles = roles,
                Permissions = permissions
            };

            return View(model);
        }

        public async Task<ActionResult> EditRoleModal(int roleId)
        {
            var role = await _roleAppService.Get(new EntityDto(roleId));
            var permissions = (await _roleAppService.GetAllPermissions()).Items;
            var model = new EditRoleModalViewModel
            {
                Role = role,
                Permissions = permissions
            };
            return View("_EditRoleModal", model);
        }
    }
}
