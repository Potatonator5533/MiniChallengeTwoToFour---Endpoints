namespace MiniChallengeTwoToFour___Endpoints.Services.Endpoint2;

public class Sentence : ISentence
{
    public string AboutYou(string name, string wakeTime)
    {
        return "Your name is " + name + " and you woke up at " + wakeTime;
    }
}