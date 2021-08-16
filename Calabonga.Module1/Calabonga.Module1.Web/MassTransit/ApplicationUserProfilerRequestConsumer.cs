using Calabonga.Contracts;
using MassTransit;
using System.Threading.Tasks;

namespace Calabonga.Module1.Web.MassTransit
{
    public class ApplicationUserProfilerRequestConsumer
        : IConsumer<IApplicationUserProfileRequest>
    {
        public async Task Consume(ConsumeContext<IApplicationUserProfileRequest> context)
        {
            var request = context.Message;
            var data = new ApplicationUserProfileResponse()
            {
                Id = request.Id,
                PetName = "Pussy",
                FavoriteColor = "Magenta",
                Skills = "NET, Core, Blazor, MVC, Silverlight"
            };
            await context.RespondAsync(data);


        }
    }
}
