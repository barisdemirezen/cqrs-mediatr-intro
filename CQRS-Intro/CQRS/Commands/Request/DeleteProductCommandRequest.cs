using MediatR;
using CQRS_Intro.CQRS.Commands.Response; 

namespace CQRS_Intro.CQRS.Commands.Request
{
    public class DeleteProductCommandRequest : IRequest<DeleteProductCommandResponse>
    {
        public int Id { get; set; }
    }
}
