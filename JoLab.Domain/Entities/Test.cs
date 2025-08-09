namespace JoLab.Domain.Entities
{
    public class Test : BaseEntity<Guid>
    {
        public string Code { get; set; }
        public string NameAr { get; set; }
        public string NameOt { get; set; }
        public bool IsActive { get; set; }
        public bool IsOnSite { get; set; }
        public Guid? TubeTypeId { get; set; }
        public virtual TubeType TubeType { get; set; }
        public bool IsRepetitionAllowed {  get; set; } 
        public virtual ICollection<TestInsurancePlan> TestInsurancePlan { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ICollection<TestNormalRange> TestNormalRanges { get; set; }
        public virtual ICollection<ClientTest> ClientTests { get; set; }

    }
}
