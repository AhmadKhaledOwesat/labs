namespace JoLab.Domain.Entities.Filters
{
    public class DoctorFilter : SearchParameters<Doctor>
    {
        public Guid SpecialtyId { get; set; }
    }

}
