namespace JoLab.Domain.Entities
{
    public class Indicator : BaseEntity<Guid>
    {
        public string NameAr { get; set; }
        public string NameOt { get; set; }
        public string Icon { get; set; }
        public int IsActive { get; set; }
        public virtual ICollection<ClientIndicator> ClientIndicators { get; set; }
    }
}
