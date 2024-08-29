using Microsoft.AspNetCore.Mvc;
using NeAvito.Application.AppServices.User.Services;
using NeAvito.Contracts.User;
using System.Net;

namespace NeAvito.Hosts.Api.Controllers
{
    [ApiController]
    [Route("/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [ProducesResponseType(typeof(List<UserDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpGet]
        public async Task<ActionResult<UserDto>> GetAllUsersAsync(CancellationToken cancellationToken)
        {
            var users = await _userService.GetAllAsync(cancellationToken);
            return users == null ? NotFound() : Ok(users);
        }

        [ProducesResponseType(typeof(UserDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<UserDto>> GetUserByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var user = await _userService.GetByIdAsync(id, cancellationToken);
            return user == null ? NotFound() : Ok(user);
        }

        [ProducesResponseType(typeof(Guid), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpPost]
        public async Task<ActionResult<UserDto>> AddUserAsync(UserCreateDto userCreateDto, CancellationToken cancellationToken)
        {
            var userId = await _userService.AddAsync(userCreateDto, cancellationToken);
            return userId == Guid.Empty ? BadRequest() : Ok(userId);
        }

        [ProducesResponseType(typeof(UserDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpPut("{id:guid}")]
        public async Task<ActionResult<UserDto>> UpdateUserAsync(Guid id, UserUpdateDto userUpdateDto, CancellationToken cancellationToken)
        {
            var user = await _userService.UpdateAsync(id, userUpdateDto, cancellationToken);
            return user == null ? NotFound() : Ok(user);
        }

        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<UserDto>> DeleteUserByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var result = await _userService.DeleteByIdAsync(id, cancellationToken);
            return result ? Ok() : NotFound();
        }
    }
}
