namespace CQRS_Intro.CQRS.Commands.Response
{
    public class CreateProductCommandResponse
    {
        public bool IsSuccess { get; set; }
        public int Id { get; set; }
    }
}
