namespace JoLab.Domain.Entities.Filters
{
    public class OrderDetailsFilter : SearchParameters<OrderDetails>
    {
        public Guid OrderId { get; set; }
    }

}
