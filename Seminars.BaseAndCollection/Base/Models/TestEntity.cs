namespace Seminars.BaseAndCollection.Base;

public class TestEntity
{
    public TestEntity(string name, long testId)
    {
        Name = name;
        TestId = testId;
    }

    public string Name { get; set; }
    public long TestId { get; set; }
}