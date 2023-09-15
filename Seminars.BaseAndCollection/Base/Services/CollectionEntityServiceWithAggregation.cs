namespace Seminars.BaseAndCollection.Base;

// Пример агрегации, тк наш CollectionEntityService не создает обьект List<CollectionEntity>

public class CollectionEntityServiceWithAggregation : IService
{
    private List<CollectionEntity> _collectionEntities;
    
    public CollectionEntityServiceWithAggregation(List<CollectionEntity> collectionEntities)
    {
        _collectionEntities = collectionEntities;
    }
    
    public void AddEntityToBase(CollectionEntity entity)
    {
        if (entity is null)
        {
            throw new NullReferenceException("Entity is null");
        }
        
        var oldItem = _collectionEntities.FirstOrDefault(x => x.Id == entity.Id);
        if (oldItem != null)
        {
            throw new Exception("Element already in list");
        }
        
        _collectionEntities.Add(entity);
    }

    public bool RemoveEntityFromBase(long id)
    {
        var oldItem = _collectionEntities.FirstOrDefault(x => x.Id == id);
        if (oldItem is null)
        {
            return false;
        }

        _collectionEntities.Remove(oldItem);
        return true;
    }

    public IReadOnlyCollection<CollectionEntity> GetAllEntitiesFromBase()
    {
        return _collectionEntities.AsReadOnly();
    }
}