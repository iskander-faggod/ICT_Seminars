namespace Seminars.BaseAndCollection.Base;

public interface IService
{
    void AddEntityToBase(CollectionEntity entity);
    bool RemoveEntityFromBase(long id);
    IReadOnlyCollection<CollectionEntity> GetAllEntitiesFromBase();
}