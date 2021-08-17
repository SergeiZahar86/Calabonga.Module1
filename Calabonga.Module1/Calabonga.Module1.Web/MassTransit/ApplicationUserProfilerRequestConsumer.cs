using Calabonga.Contracts;
using MassTransit;
using System;
using System.Threading.Tasks;

namespace Calabonga.Module1.Web.MassTransit
{
    public class ApplicationUserProfilerRequestConsumer
        : IConsumer<IApplicationUserProfileRequest>
    {
        public async Task Consume(ConsumeContext<IApplicationUserProfileRequest> context)
        {
            IApplicationUserProfileRequest request = context.Message;
            Guid fff = request.Id;
            var data = new ApplicationUserProfileResponse
            {
                PetName = "Pussy",
                FavoriteColor = "Magenta",
                Skills = "NET, Core, Blazor, MVC, Silverlight",
                Id = request.Id
            };
            await context.RespondAsync(data);


        }
    }
}
