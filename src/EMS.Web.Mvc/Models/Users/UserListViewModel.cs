using System.Collections.Generic;
using EMS.Roles.Dto;
using EMS.Users.Dto;

namespace EMS.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
