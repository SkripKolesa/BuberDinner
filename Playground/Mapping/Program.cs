using Mapping;
using Mapster;
using MapsterMapper;

internal class Program
{
    private static void Main(string[] args)
    {
        var user = UserGenerator.GenerateRandom();
        var traceId = Guid.NewGuid();
        IMapper _mapper = new Mapper();
        TypeAdapterConfig.GlobalSettings.NewConfig<(User user, Guid traceId), UserResponse>()
            .Map(dest => dest, src => user)
            .Map(dest => dest.TraceId, src => traceId);

        TypeAdapterConfig.GlobalSettings.ForDestinationType<IValidatable>()
            .AfterMapping(dest => dest.Validate());

        var userResponse = _mapper.Map<UserResponse>((user, traceId));
        Console.WriteLine(user);
        Console.WriteLine(userResponse);
    }
}
