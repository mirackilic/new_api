using TodoApi.Base;

namespace TodoApi.Entity
{
    public class Product : BaseEntity
    { 
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public string  Adress { get; set; }
        public string UserId { get; set; }
    }
}