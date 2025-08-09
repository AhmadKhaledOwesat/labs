namespace JoLab.Domain.Entities
{
    public class Specialty : BaseEntity<Guid>
    {
        public string NameAr { get; set; }
        public string NameOt { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
