using Library.Communication.Request;
using Library.Communication.Response;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LibraryController : ControllerBase
{

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestRegisterBookJson request)
    {   var response = new ResponseRegisterBookJson()
    {
        Id = request.Id,
        Title = request.Title
    };
        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllBooksJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll([FromBody] RequestRegisterBookJson request)
    {
        if (request == null)
        {
            return NoContent();
        } else
        {
            return Ok();
        }
    }

    [HttpPut]
    [ProducesResponseType(typeof(ResponseAllBooksJson), StatusCodes.Status200OK)]
    [Route("{id}")]
    public IActionResult Update([FromRoute] int id, [FromBody] ResponseShortBookJson request)
    {
        return Ok();
    }

    [HttpDelete]
    [ProducesResponseType(typeof(ResponseAllBooksJson), StatusCodes.Status200OK)]
    [Route("{id}")]
    public IActionResult Delete([FromRoute] int id, [FromBody] ResponseShortBookJson request)
    {
        return Ok();
    }

}
