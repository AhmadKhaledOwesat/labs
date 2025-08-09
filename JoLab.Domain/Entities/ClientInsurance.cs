using JoLab.Domain.Enum;

namespace JoLab.Domain.Entities
{
    public class ClientInsurance : BaseEntity<Guid>
    {
        public DependencyType DependencyType { get; set; }
        public Guid InsuranceCompanyId { get; set; }
        public virtual InsuranceCompany InsuranceCompany { get; set; }
        public Guid ClientId { get; set; }
        public virtual Client Client { get; set; }
        public decimal ClientShare {  get; set; }   
        public string CardNumber { get; set; }
        public string PolicyNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public InsuranceLevel InsuranceLevel { get; set; }
    }
}
