namespace CQRS_Intro.CQRS.Queries.Response
{
    public class GetAllProductsQueryResponse
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public double Price { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
