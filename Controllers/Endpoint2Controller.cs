using MiniChallengeTwoToFour___Endpoints.Services.Endpoint2;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallengeTwoToFour___Endpoints.Controllers.Endpoint2Controller;

[ApiController]
[Route("controller")]

public class Endpoint2Controller : ControllerBase
{
    private readonly ISentence _sentence;

    public Endpoint2Controller(ISentence Setence)
    {
        _sentence = Setence;
    }

    [HttpGet]
    [Route("AboutYou/{name}/{wakeTime}")]
    public string AboutYou(string name, string wakeTime)
    {
        return _sentence.AboutYou(name, wakeTime);
    }
}