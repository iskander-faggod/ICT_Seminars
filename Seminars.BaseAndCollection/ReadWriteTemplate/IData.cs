using Seminars.BaseAndCollection.Base;

namespace Seminars.BaseAndCollection.ReadWriteTemplate;

public interface IData
{
    List<CollectionEntity> GetData();
    void InsertData(CollectionEntity entity);
    bool RemoveData(CollectionEntity entity);
}