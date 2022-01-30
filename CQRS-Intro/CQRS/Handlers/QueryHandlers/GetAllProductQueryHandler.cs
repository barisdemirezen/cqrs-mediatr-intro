using AutoMapper;
using CQRS_Intro.CQRS.Queries.Request;
using CQRS_Intro.CQRS.Queries.Response;
using CQRS_Intro.DbContext;
using MediatR;

namespace CQRS_Intro.CQRS.Handlers.QueryHandlers
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, List<GetAllProductsQueryResponse>>
    {
        private readonly IMapper _mapper;
        public GetAllProductsQueryHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        public Task<List<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var response = _mapper.Map<List<GetAllProductsQueryResponse>>(Context.Products);
            return Task.FromResult(response);
        }
    }
}
