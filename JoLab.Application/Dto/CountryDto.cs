namespace JoLab.Application.Dto
{
    public class CountryDto : BaseDto<Guid>
    {
        public string NameAr { get; set; }
        public string NameOt { get; set; }
        public bool IsActive { get; set; }
        public ICollection<CityDto> Cities { get; set; }
    }
}
