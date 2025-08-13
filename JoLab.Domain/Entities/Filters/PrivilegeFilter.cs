namespace JoLab.Domain.Entities.Filters
{
    public class PrivilegeFilter : SearchParameters<Privilege>
    {
        public string Name { get; set; }
        public Guid? CompanyId { get; set; }

    }
}
