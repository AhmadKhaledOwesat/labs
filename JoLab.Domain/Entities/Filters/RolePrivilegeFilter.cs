﻿namespace JoLab.Domain.Entities.Filters
{
    public class RolePrivilegeFilter : SearchParameters<RolePrivilege>
    {
        public Guid? RoleId { get; set; }
    }
}
