namespace JoLab.Domain.Entities
{
    public class TubeType : BaseEntity<Guid>
    {
        public string NameAr { get; set; }
        public string NameOt { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Test> Tests { get; set; }

    }
}
