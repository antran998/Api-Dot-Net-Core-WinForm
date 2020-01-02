using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Storage.Contracts.v1.Responses;
using StrorageRestApi.Contracts.v1;
using StrorageRestApi.Contracts.v1.Requests;
using StrorageRestApi.Contracts.v1.Responses;
using StrorageRestApi.Services;

namespace StrorageRestApi.Controllers.v1
{
    public class IdentityController : Controller
    {
        private readonly IIdentityService _identityService ;

        public IdentityController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        [HttpPost(ApiRoutes.Identity.Register)]
        public async Task<IActionResult> Register([FromBody] UserRegistrationRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new AuthFailedResponse
                {
                    Errors = ModelState.Values.SelectMany(x=>x.Errors.Select(xx=>xx.ErrorMessage))
                });
            }

            var authResponse = await _identityService.RegisterAsync(request.Email, request.Password,
                request.Name,request.Confirm,request.Phone);

            if (!authResponse.Success)
            {
                return BadRequest(new AuthFailedResponse
                { 
                    Errors = authResponse.Errors
                });
            }

            return Ok(new AuthSuccessResponse
            {
                Token = authResponse.Token,
                RefreshToken = authResponse.RefreshToken
            });
        }

        [HttpPost(ApiRoutes.Identity.Login)]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest request)
        {
            var authResponse = await _identityService.LoginAsync(request.Email, request.Password);

            if (!authResponse.Success)
            {
                return BadRequest(new AuthFailedResponse
                {
                    Errors = authResponse.Errors
                });
            }

            return Ok(new AuthSuccessResponse
            {
                Token = authResponse.Token,
                RefreshToken = authResponse.RefreshToken
            });
        }

        [HttpPost(ApiRoutes.Identity.Refresh)]
        public async Task<IActionResult> Login([FromBody] RefreshTokenRequest request)
        {
            var authResponse = await _identityService.RefreshTokenAsync(request.Token, request.RefreshToken);

            if (!authResponse.Success)
            {
                return BadRequest(new AuthFailedResponse
                {
                    Errors = authResponse.Errors
                });
            }

            return Ok(new AuthSuccessResponse
            {
                Token = authResponse.Token,
                RefreshToken = authResponse.RefreshToken
            });
        }

        [HttpGet(ApiRoutes.Identity.UserInfo)]
        public async Task<IActionResult> GetUserInfo([FromRoute]string token)
        {
            var user = await _identityService.GetInfoResponse(token);
            return Ok(new UserInfoResponse
            {
                Email = user.Email,
                Name = user.Name,
                Id = user.Id,
                Phone = user.Phone
            });
        }
    }
}