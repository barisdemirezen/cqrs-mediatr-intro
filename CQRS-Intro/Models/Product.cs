namespace CQRS_Intro.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public double Price { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
