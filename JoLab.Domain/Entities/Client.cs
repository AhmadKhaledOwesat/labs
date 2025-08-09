using JoLab.Domain.Enum;

namespace JoLab.Domain.Entities
{
    public class Client : BaseEntity<Guid>
    {
        public string ClientNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string SurName { get; set; }
        public string ProfileImage { get; set; }
        public bool IsPortalUser { get; set; }
        public string MobileNumber { get; set; }
        public string SecondaryMobileNumber { get; set; }
        public string Email { get; set; }
        public string NationalId { get; set; }
        public string Address { get; set; }
        public string PassportNumber { get; set; }
        public string MedicalInformation { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public Gender GenderCode { get; set; }
        public Guid? CountryId { get; set; }
        public Guid? CityId { get; set; }
        public virtual Country Country { get; set; }
        public virtual City City { get; set; }
        public ResultDeliveryType ResultDeliveryType { get; set; }
        public virtual ICollection<ClientFile> ClientFiles { get; set; }
        public virtual ICollection<ClientIndicator> ClientIndicators { get; set; }
        public virtual ICollection<InsuranceCompany> InsuranceCompanies { get; set; }
        public virtual ICollection<ClientTest> ClientTests { get; set; }

    }
}
