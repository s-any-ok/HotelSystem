namespace Hotel.BLL.Model
{
    public class Room<TKey>
    {
        public TKey Id { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }

        public TKey StatusId { get; set; }

        public TKey CategoryId { get; set; }
    }
}
