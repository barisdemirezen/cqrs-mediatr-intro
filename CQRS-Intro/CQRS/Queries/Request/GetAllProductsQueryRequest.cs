using CQRS_Intro.CQRS.Queries.Response;
using MediatR;

namespace CQRS_Intro.CQRS.Queries.Request
{
    public class GetAllProductsQueryRequest : IRequest<List<GetAllProductsQueryResponse>>
    {
    }
}
