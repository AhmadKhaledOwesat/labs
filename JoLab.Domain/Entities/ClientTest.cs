namespace JoLab.Domain.Entities
{
    public class ClientTest : BaseEntity<Guid>
    {
        public Guid? ClientId { get; set; }
        public virtual Client Client { get; set; }
        public Guid? TestId { get; set; }
        public virtual Test Test { get; set; }
    }
}
