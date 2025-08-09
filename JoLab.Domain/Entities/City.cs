namespace JoLab.Domain.Entities
{
    public class City : BaseEntity<Guid>
    {
        public string NameAr { get; set; }
        public string NameOt { get; set; }
        public bool IsActive { get; set; }
        public Guid CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
