namespace JoLab.Domain.Entities
{
    public class Country : BaseEntity<Guid>
    {
        public string NameAr { get; set; }
        public string NameOt { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
