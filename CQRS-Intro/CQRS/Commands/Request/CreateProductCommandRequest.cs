using CQRS_Intro.CQRS.Commands.Response;
using MediatR;

namespace CQRS_Intro.CQRS.Commands.Request
{
    public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
    {
        public string? Title { get; set; }
        public double Price { get; set; }
    }
}
