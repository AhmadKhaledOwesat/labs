namespace JoLab.Application.Dto
{
    public class IndicatorDto : BaseDto<Guid>
    {
        public string NameAr { get; set; }
        public string NameOt { get; set; }
        public string Icon { get; set; }
        public int IsActive { get; set; }
        public ICollection<ClientIndicatorDto> ClientIndicators { get; set; }
    }
}
