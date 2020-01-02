using Refit;
using Storage.Contracts.v1.Responses;
using StrorageRestApi.Contracts.v1.Requests;
using StrorageRestApi.Contracts.v1.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Storage.sdk
{
    public interface IIdentityApi
    {
        [Post("/api/v1/identity/register")]
        Task<ApiResponse<AuthSuccessResponse>> RegisterAsync([Body]UserRegistrationRequest registrationRequest);

        [Post("/api/v1/identity/login")]
        Task<ApiResponse<AuthSuccessResponse>> LoginAsync([Body]UserLoginRequest loginRequest);

        [Post("/api/v1/identity/refresh")]
        Task<ApiResponse<AuthSuccessResponse>> RefreshAsync([Body]RefreshTokenRequest refreshRequest);
        [Get("/api/v1/identity/userInfo/{token}")]
        Task<ApiResponse<UserInfoResponse>> GetUserInfoAsync(string token);
    }
}
