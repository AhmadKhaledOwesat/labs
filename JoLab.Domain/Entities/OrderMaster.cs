using JoLab.Domain.Enum;

namespace JoLab.Domain.Entities
{
    public class OrderMaster : BaseEntity<Guid>
    {
        public decimal OrderAmount { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal NetAmount { get; set; }
        public string OrderNumber { get; set; }
        public OrderType OrderType { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Guid? DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public string Comments { get; set; }
        public bool IsRoutine { get; set; }
        public PaymentType PaymentType { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public Guid? ClientInsuranceId { get; set; }
        public virtual ClientInsurance ClientInsurance { get; set; }
        public string InsuranceFormNumber { get; set; }
        public DateTime?  OrderDate { get; set; }   
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
