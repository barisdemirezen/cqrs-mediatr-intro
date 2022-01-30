using CQRS_Intro.Models;

namespace CQRS_Intro.DbContext
{
    public static class Context
    {
        private static List<Product>? _products;
        public static List<Product> Products
        {
            get
            {
                if (_products == null)
                {
                    _products = new List<Product>
                    {
                        new Product{ Id = 1, Title = "Sneaker", Price = 40.8 , CreateDate = DateTime.Now.AddDays(-1) },
                        new Product{ Id = 2, Title = "Coat", Price = 20.5 , CreateDate = DateTime.Now.AddDays(-2) },
                        new Product{ Id = 3, Title = "Scarf", Price = 9.90 , CreateDate = DateTime.Now.AddHours(-3) },
                    };
                }

                return _products;
            }
        }
    }
}
