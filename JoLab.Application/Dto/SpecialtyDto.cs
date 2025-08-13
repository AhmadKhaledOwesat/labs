namespace JoLab.Application.Dto
{
    public class SpecialtyDto : BaseDto<Guid>
    {
        public string NameAr { get; set; }
        public string NameOt { get; set; }
        public bool IsActive { get; set; }
        public ICollection<DoctorDto> Doctors { get; set; }
    }
}
