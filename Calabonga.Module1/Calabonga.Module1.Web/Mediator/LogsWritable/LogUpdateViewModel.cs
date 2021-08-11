using AutoMapper;
using Calabonga.AspNetCore.Controllers.Handlers;
using Calabonga.AspNetCore.Controllers.Queries;
using Calabonga.Module1.Entities;
using Calabonga.Module1.Web.ViewModels.LogViewModels;
using Calabonga.UnitOfWork;
using System;

namespace Calabonga.Module1.Web.Mediator.LogsWritable
{
    /// <summary>
    /// Request: Returns ViewModel for entity Log creation
    /// </summary>
    public class LogUpdateViewModelRequest : UpdateViewModelQuery<LogUpdateViewModel>
    {
        public LogUpdateViewModelRequest(Guid id) : base(id)
        {
        }
    }

    /// <summary>
    /// Response: Returns ViewModel for entity Log creation
    /// </summary>
    public class LogUpdateViewModelRequestHandler : UpdateViewModelHandlerBase<LogUpdateViewModelRequest, Log, LogUpdateViewModel>
    {
        public LogUpdateViewModelRequestHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
