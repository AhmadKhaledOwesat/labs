namespace JoLab.Domain.Entities.Filters
{
    public class OrderMasterFilter : SearchParameters<OrderMaster>
    {
        public Guid ClientId { get; set; }
    }

}
