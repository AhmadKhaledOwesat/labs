namespace JoLab.Application.Dto
{
    public class ClientFileDto : BaseDto<Guid>
    {
        public Guid? ClientId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FilePath { get; set; }
    }
}
