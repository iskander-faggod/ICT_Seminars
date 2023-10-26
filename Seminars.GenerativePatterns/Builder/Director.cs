namespace Seminars.GenerativePatterns.Builder;

public class ClassDirector
{
    public BuildClass CreateRich(ClassBuilder builder)
    {
        return builder
            .SetName("rich")
            .SetTime(DateTime.Now)
            .Build();
    }
    
    public BuildClass CreatePoor(ClassBuilder builder)
    {
        return builder
            .SetName("poor")
            .SetTime(DateTime.Now)
            .Build();
    }
}