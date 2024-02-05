using MiniChallengeTwoToFour___Endpoints.Services.Endpoint1;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallengeTwoToFour___Endpoints.Controllers.Endpoint1Controller;

[ApiController]
[Route("controller")]

public class Endpoint1Controller : ControllerBase
{
    private readonly ICounting _counting;

    public Endpoint1Controller(ICounting Counting)
    {
        _counting = Counting;
    }

    [HttpGet]
    [Route("AddNumbers/{num1}/{num2}")]
    public string AddNumbers(int num1, int num2)
    {
        return _counting.AddNumbers(num1, num2);
    }
}