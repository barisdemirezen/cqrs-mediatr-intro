using CQRS_Intro.CQRS.Queries.Response;
using MediatR;

namespace CQRS_Intro.CQRS.Queries.Request
{
    public class GetProductByIdQueryRequest : IRequest<GetProductByIdQueryResponse>
    {
        public int Id { get; set; }
    }
}
