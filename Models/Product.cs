namespace WebApplication2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        //one to many?
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
