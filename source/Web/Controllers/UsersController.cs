using Architecture.Application;
using Architecture.CrossCutting;
using Architecture.Model;
using DotNetCore.AspNetCore;
using DotNetCore.Objects;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Architecture.Web
{
    [ApiController]
    [ControllerRoute]
    public class UsersController : ControllerBase
    {
        private readonly IUserApplicationService _userApplicationService;

        public UsersController(IUserApplicationService userApplicationService)
        {
            _userApplicationService = userApplicationService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(AddUserModel model)
        {
            return await _userApplicationService.AddAsync(model).ResultAsync();
        }

        [EnumAuthorize(Roles.Admin)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            return await _userApplicationService.DeleteAsync(id).ResultAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(long id)
        {
            return await _userApplicationService.GetAsync(id).ResultAsync();
        }

        [HttpPatch("{id}/Inactivate")]
        public async Task InactivateAsync(long id)
        {
            await _userApplicationService.InactivateAsync(id);
        }

        [HttpGet("Grid")]
        public async Task<IActionResult> ListAsync([FromQuery]PagedListParameters parameters)
        {
            return await _userApplicationService.ListAsync(parameters).ResultAsync();
        }

        [HttpGet]
        public async Task<IActionResult> ListAsync()
        {
            return await _userApplicationService.ListAsync().ResultAsync();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(UpdateUserModel model)
        {
            return await _userApplicationService.UpdateAsync(model).ResultAsync();
        }
    }
}
