namespace JoLab.Application.Dto
{
    public class ClientIndicatorDto : BaseDto<Guid>
    {
        public Guid? ClientId { get; set; }
        public Guid? IndicatorId { get; set; }
        public string IndicatorName { get; set; }
    }
}
