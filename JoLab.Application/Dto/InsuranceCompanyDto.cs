namespace JoLab.Application.Dto
{
    public class InsuranceCompanyDto : BaseDto<Guid>
    {
        public string NameAr { get; set; }
        public string NameOt { get; set; }
        public string IsActive { get; set; }
        public Guid? ParentId { get; set; }
        public string MotherCompanyName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal ClientShare { get; set; }
        public virtual ICollection<InsuranceCompanyDto> InsuranceCompanies { get; set; }
        //   public virtual ICollection<TestInsurancePlan> TestInsurancePlans { get; set; }
    }
}
