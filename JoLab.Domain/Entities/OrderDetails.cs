namespace JoLab.Domain.Entities
{
    public class OrderDetails : BaseEntity<Guid>
    {
        public Guid TestId { get; set; }
        public virtual Test Test { get; set; }
        public Guid OrderMasterId { get; set; }
        public virtual OrderMaster OrderMaster { get; set; }
        public int Quantity {  get; set; }  
        public Guid DestinationId { get; set; }
        public virtual ClientTest Destination { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal ClientShare {  get; set; } 
        public decimal CompanyShare { get; set; }
        public bool IsInsuranceApproved { get; set; }
    }
}
