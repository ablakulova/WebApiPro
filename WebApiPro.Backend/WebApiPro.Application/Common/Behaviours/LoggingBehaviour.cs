using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebApiPro.Application.Common.Behaviours
{
    public class LoggingBehaviour<TRequest, TResponse>
           : IPipelineBehavior<TRequest, TResponse> where TRequest
           : IRequest<TResponse>
    {
        public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            throw new NotImplementedException();
        }
    }
}
