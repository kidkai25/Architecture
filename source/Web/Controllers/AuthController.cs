using Architecture.Application;
using Architecture.Model;
using DotNetCore.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Architecture.Web
{
    [ApiController]
    [ControllerRoute]
    public class AuthController : ControllerBase
    {
        private readonly IAuthApplicationService _authApplicationService;

        public AuthController(IAuthApplicationService authApplicationService)
        {
            _authApplicationService = authApplicationService;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> SignInAsync(SignInModel model)
        {
            return await _authApplicationService.SignInAsync(model).ResultAsync();
        }
    }
}
