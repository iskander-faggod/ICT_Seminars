using Xunit;
using Xunit.Abstractions;

namespace Seminars.BaseAndCollection.Base.Tests;

public class TestBase
{
    private readonly ITestOutputHelper output;

    public TestBase(ITestOutputHelper output)
    {
        this.output = output;
    }

    [Fact]
    public void TestAgregation()
    {
        var list = new List<CollectionEntity>
        {
            new CollectionEntity(1, "name1", true),
            new CollectionEntity(2, "name2", false),
            new CollectionEntity(3, "name3", true)
        };

        var service = new CollectionEntityServiceWithAggregation(list);
        Assert.True(service.GetAllEntitiesFromBase().Count == 3);

        var newItem = new CollectionEntity(4, "name4", false);
        service.AddEntityToBase(newItem);

        var newItem2 = new CollectionEntity(5, "name4.2", false);
        service.AddEntityToBase(newItem2);
        Assert.True(service.GetAllEntitiesFromBase().Count == 5);
        
        service.RemoveEntityFromBase(newItem2.Id);
        Assert.True(service.GetAllEntitiesFromBase().Count == 4);

    }
    
    [Fact]
    public void TestComposition()
    {
        var list = new List<CollectionEntity>
        {
            new CollectionEntity(1, "name1", true),
            new CollectionEntity(2, "name2", false),
            new CollectionEntity(3, "name3", true)
        };

        var service = new CollectionEntityServiceWithComposition();
        Assert.True(service.GetAllEntitiesFromBase().Count == 0);

        foreach (var entity in list)
        {
            service.AddEntityToBase(entity);
        }
        
        Assert.True(service.GetAllEntitiesFromBase().Count == 3);

    }

    [Fact]
    public void CreateCar()
    {
        var car1 = new TeslaCar(3, 20, "Тесла машина");
        var car2 = new MercedezCar(3, 20, "Мерседез машина");
        car1.AddWheel();
        car2.AddWheel();
        
        car1.AddDistance(20);
        car2.AddDistance(20);

        var cars = new List<ICar>()
        {
            car1, car2
        };

        foreach (var car in cars)
        {
            output.WriteLine(car.GetDistance().ToString());
        }
    }

    [Fact]
    public void WhereTest_GetAllNotDeleted_Data()
    {
        var list = new List<CollectionEntity>
        {
            new CollectionEntity(1, "name1", true),
            new CollectionEntity(2, "name2", false),
            new CollectionEntity(3, "name3", true)
        };

        var result = list
            .Where(item => !item.IsDeleted);

        IEnumerable<CollectionEntityDto> collectionEntityDtos = list
            .Select(entity => new CollectionEntityDto()
            {
                Id = entity.Id,
                IsDeleted = entity.IsDeleted,
            });

        /*foreach (var collectionEntityDto in collectionEntityDtos)
        {
            output.WriteLine(collectionEntityDto.Id.ToString());
            output.WriteLine(collectionEntityDto.IsDeleted.ToString());
        }*/
        
        // output.WriteLine(collectionEntityDtos.Sum(x => x.Id).ToString());
        //output.WriteLine(collectionEntityDtos.Max(x => x.Id).ToString());

        var sortedRecords = collectionEntityDtos.OrderByDescending(x => x.IsDeleted);
        foreach (var record in sortedRecords)
        {
            output.WriteLine($"{record.Id} {record.IsDeleted}");
        }
    }
}