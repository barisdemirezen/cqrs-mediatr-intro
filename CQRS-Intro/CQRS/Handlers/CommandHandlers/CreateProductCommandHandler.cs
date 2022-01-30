using AutoMapper;
using CQRS_Intro.CQRS.Commands.Request;
using CQRS_Intro.CQRS.Commands.Response;
using CQRS_Intro.DbContext;
using CQRS_Intro.Models;
using MediatR;

namespace CQRS_Intro.CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        private readonly IMapper _mapper;
        public CreateProductCommandHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        public Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            Product product = _mapper.Map<Product>(request);
            Context.Products.Add(product);
            CreateProductCommandResponse response = new CreateProductCommandResponse
            {
                Id = product.Id,
                IsSuccess = true
            };
            return Task.FromResult(response);
        }
    }
}
