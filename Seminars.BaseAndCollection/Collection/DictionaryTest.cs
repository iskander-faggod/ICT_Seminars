using Seminars.BaseAndCollection.Base;
using Xunit;
using Xunit.Abstractions;

namespace Seminars.BaseAndCollection.Collection;

// key - values, key - object/valuetype values - object/valuetype/IEnumerable<Object>/IEnumerable<ValueType>

// 1 - [ new CollectionEntity(2, "name2", false),  new CollectionEntity(1, "name1", false),  new CollectionEntity(3, "name3", false),]
// 2 - [ new CollectionEntity(4, "name4", false)]

// 1 -  [new CollectionEntity(1, "name1", false),  new CollectionEntity(3, "name3", false)].Count == 2;

public class DictionaryTest
{
    private readonly ITestOutputHelper output;
    
    private Dictionary<int, List<CollectionEntity>> _entitiesById;
    private List<CollectionEntity> _entities = new List<CollectionEntity>
    {
        new CollectionEntity(1, "name1", true),
        new CollectionEntity(2, "name2", false),
        new CollectionEntity(3, "name3", true)
    };
    
    public DictionaryTest(ITestOutputHelper output)
    {
        this.output = output;
        _entitiesById = new Dictionary<int, List<CollectionEntity>>();
    }

    [Fact]
    public void Add()
    {
        _entitiesById.Add(1, _entities);
        _entitiesById.Add(1, _entities);
    }

    [Fact]
    public void CheckValues()
    {
        _entitiesById.Add(1, _entities);
        
        foreach (var value in _entitiesById.Values)
        {
            foreach (var x in value)
            {
                output.WriteLine(x.Id.ToString());
            }
        }
    }
    
    [Fact]
    public void CheckKeys()
    {
        _entitiesById.Add(1, _entities);
        
        foreach (var key in _entitiesById.Keys)
        {
            output.WriteLine(key.ToString());
        }
    }
}
