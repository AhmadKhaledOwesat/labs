namespace JoLab.Domain.Entities.Filters
{
    public class ClientFileFilter : SearchParameters<ClientFile>
    {
        public Guid ClientId { get; set; }
    }

}
