namespace MongoTtlIndexExample.Core.Data.Entity
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
