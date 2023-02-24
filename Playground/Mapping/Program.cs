using Mapping;
using Mapster;

internal class Program
{
    private static void Main(string[] args)
    {
        var user = UserGenerator.GenerateRandom();
        TypeAdapterConfig.GlobalSettings.NewConfig<User, UserResponse>()
            .Map(dest => dest.FullName, src => $"{src.FirstName} {src.LastName}");

        TypeAdapterConfig.GlobalSettings.ForType<User, UserResponse>()
            .Map(dest => dest.Id, src => src.Id + 1);

        var userResponse = user.Adapt<UserResponse>();
        Console.WriteLine(user);
        Console.WriteLine(userResponse);
    }
}
