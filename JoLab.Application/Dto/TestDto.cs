namespace JoLab.Application.Dto
{
    public class TestDto : BaseDto<Guid>
    {
        public string Code { get; set; }
        public string NameAr { get; set; }
        public string NameOt { get; set; }
        public bool IsActive { get; set; }
        public bool IsOnSite { get; set; }
        public Guid? TubeTypeId { get; set; }
        public string TubeTypeName { get; set; }
        public bool IsRepetitionAllowed { get; set; }
        //  public  ICollection<TestInsurancePlan> TestInsurancePlan { get; set; }
        public ICollection<OrderDetailsDto> OrderDetails { get; set; }
        //  public  ICollection<TestNormalRange> TestNormalRanges { get; set; }
        public ICollection<ClientTestDto> ClientTests { get; set; }
    }
}
