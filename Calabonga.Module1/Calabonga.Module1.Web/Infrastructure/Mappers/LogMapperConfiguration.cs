using Calabonga.Module1.Entities;
using Calabonga.Module1.Web.Infrastructure.Mappers.Base;
using Calabonga.Module1.Web.ViewModels.LogViewModels;
using Calabonga.UnitOfWork;

namespace Calabonga.Module1.Web.Infrastructure.Mappers
{
    /// <summary>
    /// Mapper Configuration for entity Log
    /// </summary>
    public class LogMapperConfiguration : MapperConfigurationBase
    {
        /// <inheritdoc />
        public LogMapperConfiguration()
        {
            CreateMap<LogCreateViewModel, Log>()
                .ForMember(x => x.Id, o => o.Ignore());

            CreateMap<Log, LogViewModel>();

            CreateMap<IPagedList<Log>, IPagedList<LogViewModel>>()
                .ConvertUsing<PagedListConverter<Log, LogViewModel>>();
        }
    }
}
