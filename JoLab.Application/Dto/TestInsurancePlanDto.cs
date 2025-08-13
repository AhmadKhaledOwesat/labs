namespace JoLab.Application.Dto
{
    public class TestInsurancePlanDto : BaseDto<Guid>
    {
        public Guid TestId { get; set; }
        public string TestName { get; set; }
        public Guid InsuranceCompanyId { get; set; }
        public string InsuranceCompanyName { get; set; }
        public decimal Price { get; set; }
    }
}
