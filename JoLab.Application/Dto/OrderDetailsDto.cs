namespace JoLab.Application.Dto
{
    public class OrderDetailsDto : BaseDto<Guid>
    {
        public Guid TestId { get; set; }
        public string TestName { get; set; }
        public Guid OrderMasterId { get; set; }
        public int Quantity { get; set; }
        public Guid DestinationId { get; set; }
        public ClientTestDto Destination { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal ClientShare { get; set; }
        public decimal CompanyShare { get; set; }
        public bool IsInsuranceApproved { get; set; }
    }
}
