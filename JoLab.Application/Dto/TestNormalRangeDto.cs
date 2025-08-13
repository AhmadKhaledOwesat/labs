namespace JoLab.Application.Dto
{
    public class TestNormalRangeDto : BaseDto<Guid>
    {
        public string NameAr { get; set; }
        public string NameOt { get; set; }
        public decimal NormalValue { get; set; }
        public Guid TestId { get; set; }
        public string TestName { get; set; }
    }
}
