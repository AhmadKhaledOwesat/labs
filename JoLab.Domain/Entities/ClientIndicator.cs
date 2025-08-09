namespace JoLab.Domain.Entities
{
    public class ClientIndicator : BaseEntity<Guid>
    {
        public Guid? ClientId { get; set; }
        public virtual Client Client { get; set; }
        public Guid? IndicatorId { get; set; }
        public virtual Indicator Indicator { get; set; }
    }
}
