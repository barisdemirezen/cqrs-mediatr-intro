using AutoMapper;
using CQRS_Intro.CQRS.Queries.Request;
using CQRS_Intro.CQRS.Queries.Response;
using CQRS_Intro.DbContext;
using MediatR;

namespace CQRS_Intro.CQRS.Handlers.QueryHandlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQueryRequest, GetProductByIdQueryResponse>
    {
        private readonly IMapper _mapper;
        public GetProductByIdQueryHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        public Task<GetProductByIdQueryResponse> Handle(GetProductByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var result = Context.Products.FirstOrDefault(e => e.Id.Equals(request.Id));
            var response = _mapper.Map<GetProductByIdQueryResponse>(result);
            return Task.FromResult(response);
        }
    }
}
