using Mapping;
using Mapster;

internal class Program
{
    private static void Main(string[] args)
    {
        var user = UserGenerator.GenerateRandom();
        var traceId = Guid.NewGuid();

        TypeAdapterConfig.GlobalSettings.NewConfig<(User user, Guid traceId), UserResponse>()
            .Map(dest => dest, src => user)
            .Map(dest => dest.TraceId, src => traceId);

        TypeAdapterConfig.GlobalSettings.ForDestinationType<IValidatable>()
            .AfterMapping(dest => dest.Validate());

        var userResponse = (user, traceId).Adapt<UserResponse>();
        Console.WriteLine(user);
        Console.WriteLine(userResponse);
    }
}
