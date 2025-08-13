namespace JoLab.Application.Dto
{
    public class CityDto : BaseDto<Guid>
    {
        public string NameAr { get; set; }
        public string NameOt { get; set; }
        public bool IsActive { get; set; }
        public Guid CountryId { get; set; }
        public string CountryName { get; set; }
    }
}
