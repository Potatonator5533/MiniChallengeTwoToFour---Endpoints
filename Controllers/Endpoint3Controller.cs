using MiniChallengeTwoToFour___Endpoints.Services.Endpoint3;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallengeTwoToFour___Endpoints.Controllers.Endpoint3Controller;

[ApiController]
[Route("controller")]

public class Endpoint3Controller : ControllerBase
{
    private readonly IComparing _comparing;

    public Endpoint3Controller(IComparing comparing)
    {
        _comparing = comparing;
    }

    [HttpGet]
    [Route("CompareNums/{num1}/{num2}")]
    public string CompareNums(int num1, int num2)
    {
        return _comparing.CompareNums(num1, num2);
    }
}