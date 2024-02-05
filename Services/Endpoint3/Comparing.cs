namespace MiniChallengeTwoToFour___Endpoints.Services.Endpoint3;

public class Comparing : IComparing
{
    public string CompareNums(int num1, int num2)
    {
        List<string> message = new();
        if(num1 < num2)
        {
            message.Add($"{num1} is less than {num2}.");
            message.Add($"{num2} is greater than {num1}.");
            
        } else if (num1 > num2) {
            message.Add($"{num1} is greater than {num2}.") ;
            message.Add($"{num2} is less than {num1}.");
        } else {
            message.Add($"{num1} is equal to {num2}.");
            message.Add($"{num2} is equal to {num1}.");
        }

        return message[0] + "\n" + message[1];
    }
}