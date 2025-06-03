using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pets.GetAll;
using Petfolio.Application.UseCases.Pets.Register;
using Petfolio.Application.UseCases.Pets.Update;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PetsController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllPetsJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var response = new GetAllPetsUseCase().Execute();

        if (!response.Pets.Any())
        {
            return NoContent();
        }

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(
        typeof(ResponseRegisterPetJson),
        StatusCodes.Status201Created
    )]
    [ProducesResponseType(
        typeof(ResponseErrorsJson),
        StatusCodes.Status400BadRequest
    )]
    public IActionResult Register([FromBody] RequestPetJson request)
    {
        var response = new RegisterPetUseCase().Execute(request);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(
        typeof(ResponseErrorsJson),
        StatusCodes.Status400BadRequest
    )]
    public IActionResult Update(
        [FromRoute] int id,
        [FromBody] RequestPetJson request
    )
    {
        var useCase = new UpdatePetUseCase();

        useCase.Execute(id, request);

        return NoContent();
    }
}
