namespace JoLab.Domain.Entities
{
    public class TestInsurancePlan : BaseEntity<Guid>
    {
        public Guid TestId { get; set; }
        public virtual Test Test { get; set; }
        public Guid InsuranceCompanyId { get; set; }
        public virtual InsuranceCompany InsuranceCompany { get; set; }
        public decimal Price { get; set; }
    }
}
