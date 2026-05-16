namespace Domain.Entities
{
    public abstract class BaseEntity<Tkey>
    {
        public Tkey id { get; set; } = default!;
    }
}
