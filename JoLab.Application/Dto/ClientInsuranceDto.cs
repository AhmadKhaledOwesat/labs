using JoLab.Domain.Enum;

namespace JoLab.Application.Dto
{
    public class ClientInsuranceDto : BaseDto<Guid>
    {
        public DependencyType DependencyType { get; set; }
        public Guid InsuranceCompanyId { get; set; }
        public string InsuranceCompanyName { get; set; }
        public Guid ClientId { get; set; }
        public decimal ClientShare { get; set; }
        public string CardNumber { get; set; }
        public string PolicyNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public InsuranceLevel InsuranceLevel { get; set; }
    }
}
