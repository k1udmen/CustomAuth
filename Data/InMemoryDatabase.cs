using SimpleInMemoryCRUD.Models;

namespace SimpleInMemoryCRUD.Data
{
    //Bu sınıf, ürünlerin saklanacağı in-memory veritabanını temsil eder. Ürünler liste olarak örnek veri ile çalışmakta.
    public static class InMemoryDatabase
    {
        public static List<Product> Products { get; set; } = new List<Product>
        {
            new Product { Id = 1, Name = "Süt", Quantity = 20 },
            new Product { Id = 2, Name = "Ekmek", Quantity = 15 }
        };
    }
}
