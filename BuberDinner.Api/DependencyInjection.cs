using BuberDinner.Api.Common.Http;
using ErrorOr;

namespace BuberDinner.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddApi(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddProblemDetails(o => o.CustomizeProblemDetails = CustomizeProblemDetails);
        return services;
    }

    public static void CustomizeProblemDetails(ProblemDetailsContext problemContext)
    {
        if (problemContext.HttpContext.Items.TryGetValue(HttpContextItemKeys.Errors, out var errors))
        {
            var errorList = errors as List<Error>;
            if (errorList?.Any() == true)
            {
                problemContext.ProblemDetails.Extensions.Add("errorCodes", errorList.Select(e => e.Code));
            }
        }
    }
}
