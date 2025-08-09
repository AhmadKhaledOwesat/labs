namespace JoLab.Domain.Entities
{
    public record ApiResponse<T>(T Data , string Message = "" , bool IsSuccess=true);
}
