using System.ComponentModel.DataAnnotations.Schema;

namespace JoLab.Domain.Entities
{
    public class InsuranceCompany : BaseEntity<Guid>
    {
        public string NameAr { get; set; }
        public string NameOt { get; set; }
        public string IsActive { get; set; }
        public Guid? ParentId { get; set; }

        [ForeignKey(nameof(ParentId))]
        public virtual InsuranceCompany MotherCompany { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal ClientShare { get; set; }
        public virtual ICollection<InsuranceCompany> InsuranceCompanies { get; set; }
        public virtual ICollection<TestInsurancePlan> TestInsurancePlans { get; set; }
    }
}
