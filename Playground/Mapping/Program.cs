using Mapping;
using Mapster;

internal class Program
{
    private static void Main(string[] args)
    {
        var user = UserGenerator.GenerateRandom();
        var userResponse = user.Adapt<UserResponse>();
        Console.WriteLine(user);
        Console.WriteLine(userResponse);
    }
}
