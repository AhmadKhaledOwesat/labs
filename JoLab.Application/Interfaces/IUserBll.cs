using JoLab.Application.Dto;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Interfaces
{
    public interface IUserBll : IBaseBll<Users, Guid, UserFilter>
    {
        Task<ApiResponse<UsersDto>> LoginAsync(string userName, string password, string companyCode);
    }
}
