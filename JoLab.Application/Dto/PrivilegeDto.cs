﻿
namespace JoLab.Application.Dto
{
    public class PrivilegeDto : BaseDto<Guid>
    {
        public string PrivilegeName { get; set; }
        public Guid? ParentId { get; set; }
        public string Icon { get; set; }
        public string ParentName { get; set; }
        public virtual ICollection<RolePrivilegeDto> RolePrivileges { get; set; }

    }
}
