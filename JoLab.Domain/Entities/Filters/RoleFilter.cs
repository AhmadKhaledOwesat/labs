namespace JoLab.Domain.Entities.Filters
{
    public class RoleFilter : SearchParameters<Role>
    {
        public string Name { get; set; }
        public Guid? CompanyId { get; set; }

    }
}
