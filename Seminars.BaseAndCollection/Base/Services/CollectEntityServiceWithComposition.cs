namespace Seminars.BaseAndCollection.Base;


public class CollectionEntityServiceWithComposition : IService
{
    private List<CollectionEntity> _collectionEntities = new();
    
    public void AddEntityToBase(CollectionEntity entity)
    {
        _collectionEntities.Add(entity);
    }

    public bool RemoveEntityFromBase(long id)
    {
        foreach (var entity in _collectionEntities)
        {
            if (entity.Id == id)
            {
                _collectionEntities.Remove(entity);
                return true;
            }
        }

        return false;
    }

    public IReadOnlyCollection<CollectionEntity> GetAllEntitiesFromBase()
    {
        return _collectionEntities.AsReadOnly();
    }
}