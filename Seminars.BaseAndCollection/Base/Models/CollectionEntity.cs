namespace Seminars.BaseAndCollection.Base;

public class CollectionEntity
{
    public CollectionEntity(long id, string entityName, bool isDeleted)
    {
        Id = id;
        EntityName = entityName;
        IsDeleted = isDeleted;
    }

    public long Id { get; set; }
    public string EntityName { get; set; }
    public bool IsDeleted { get; set; }
}