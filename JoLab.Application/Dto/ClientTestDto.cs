namespace JoLab.Application.Dto
{
    public class ClientTestDto : BaseDto<Guid>
    {
        public Guid? ClientId { get; set; }
        public Guid? TestId { get; set; }
        public string TestName { get; set; }
    }
}
