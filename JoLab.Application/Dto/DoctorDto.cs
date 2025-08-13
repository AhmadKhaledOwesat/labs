namespace JoLab.Application.Dto
{
    public class DoctorDto : BaseDto<Guid>
    {
        public string NameAr { get; set; }
        public string NameOt { get; set; }
        public Guid SpecialtyId { get; set; }
        public string SpecialtyName { get; set; }
        //public virtual ICollection<OrderMaster> Orders { get; set; }
    }
}
