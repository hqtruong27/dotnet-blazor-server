using dotnet_blazor_server.models;

namespace dotnet_blazor_server.Service
{
    public interface IUserService
    {
        Task<BaseResponse<IList<UserResponse>>?> GetUsers(int page);
    }
}