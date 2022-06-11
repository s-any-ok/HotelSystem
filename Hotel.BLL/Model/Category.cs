namespace Hotel.BLL.Model
{
    public class Category<TKey>
    {
        public TKey Id { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
    }
}
