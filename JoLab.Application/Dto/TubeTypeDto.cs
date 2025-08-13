namespace JoLab.Application.Dto
{
    public class TubeTypeDto : BaseDto<Guid>
    {
        public string NameAr { get; set; }
        public string NameOt { get; set; }
        public bool IsActive { get; set; }
        public ICollection<TestDto> Tests { get; set; }

    }
}
