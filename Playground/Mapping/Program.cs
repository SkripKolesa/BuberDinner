using Mapping;
using Mapster;

internal class Program
{
    private static void Main(string[] args)
    {
        var user = UserGenerator.GenerateRandom();
        var config = new TypeAdapterConfig();
        config.NewConfig<User, UserResponse>()
            .Map(dest => dest.FullName, src => $"{src.FirstName} {src.LastName}");
        var userResponse = user.Adapt<UserResponse>(config);
        Console.WriteLine(user);
        Console.WriteLine(userResponse);
    }
}
