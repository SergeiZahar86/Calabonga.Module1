using AutoMapper;
using Calabonga.Microservices.Core.Validators;
using Calabonga.Module1.Entities;
using Calabonga.Module1.Web.ViewModels.LogViewModels;
using Calabonga.UnitOfWork.Controllers.Factories;
using Calabonga.UnitOfWork.Controllers.Managers;

namespace Calabonga.Module1.Web.Infrastructure.Engine.EntityManagers
{
    /// <summary>
    /// Entity manager for <see cref="Log"/>
    /// </summary>
    public class LogManager : EntityManager<LogViewModel, Log, LogCreateViewModel, LogUpdateViewModel>
    {
        /// <inheritdoc />
        public LogManager(IMapper mapper, IViewModelFactory<LogCreateViewModel, LogUpdateViewModel> viewModelFactory, IEntityValidator<Log> validator)
            : base(mapper, viewModelFactory, validator)
        {
        }
    }
}
