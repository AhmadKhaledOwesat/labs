namespace JoLab.Domain.Entities
{
    public class ClientFile : BaseEntity<Guid>
    {
        public Guid? ClientId { get; set; }
        public virtual Client Client { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FilePath { get; set; }
    }
}
