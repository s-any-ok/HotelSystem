namespace Hotel.DAL.Entities
{
    public abstract class BaseEntity<KId>
    {
        public KId Id { get; set; }
    }
}
