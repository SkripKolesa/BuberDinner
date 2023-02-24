using Mapping;

internal class Program
{
    private static void Main(string[] args)
    {
        var user = UserGenerator.GenerateRandom();
        var userResponse = new UserResponse(
            user.Id,
            user.FirstName,
            user.LastName
        );
        Console.WriteLine(user);
        Console.WriteLine(userResponse);
    }
}
