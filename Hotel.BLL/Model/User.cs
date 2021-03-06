namespace Hotel.BLL.Model
{
    public class User<TKey>
    {
        public TKey Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
