using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pets.Register;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PetsController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(
        typeof(ResponseRegisterPetJson),
        StatusCodes.Status201Created
    )]
    public IActionResult Register([FromBody] RequestRegisterPetJson request)
    {
        var response = new RegisterPetUseCase().Execute(request);

        return Created(string.Empty, response);
    }
}
