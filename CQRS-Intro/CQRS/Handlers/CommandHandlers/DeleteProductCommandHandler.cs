using CQRS_Intro.CQRS.Commands.Request;
using CQRS_Intro.CQRS.Commands.Response;
using CQRS_Intro.DbContext;
using CQRS_Intro.Models;
using MediatR;

namespace CQRS_Intro.CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
    {
        public Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            Product item = Context.Products.FirstOrDefault(e => e.Id.Equals(request.Id));

            var response = new DeleteProductCommandResponse
            {
                IsSuccess = false
            };

            if (item == null)
                return Task.FromResult(response);

            Context.Products.Remove(item);
            response.IsSuccess = true;
            return Task.FromResult(response);
        }
    }
}
