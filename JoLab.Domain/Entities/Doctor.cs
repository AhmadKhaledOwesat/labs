namespace JoLab.Domain.Entities
{
    public class Doctor : BaseEntity<Guid>
    {
        public string NameAr { get; set; }
        public string NameOt { get; set; }
        public Guid SpecialtyId { get; set; }
        public virtual Specialty Specialty { get; set; }
        public virtual ICollection<OrderMaster> Orders { get; set; }
    }
}
