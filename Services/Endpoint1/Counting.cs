namespace MiniChallengeTwoToFour___Endpoints.Services.Endpoint1;

public class Counting : ICounting
{
    public string AddNumbers(int num1, int num2)
    {
        return "The sum of " + num1 + " and " + num2 + " is " + (num1 + num2);
    }
}