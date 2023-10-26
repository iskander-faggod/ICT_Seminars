using System.ComponentModel.DataAnnotations;

namespace Seminars.GenerativePatterns.Builder;

public class ClassBuilder
{
    private BuildClass _buildClass = new();

    public ClassBuilder SetTime(DateTime dateTime)
    {
        _buildClass.CreatedAt = dateTime;
        return this;
    }

    public ClassBuilder SetName(string className)
    {
        if (string.IsNullOrWhiteSpace(className))
        {
            throw new ValidationException("incorrect name");
        }

        _buildClass.Name = className;
        return this;
    }

    public BuildClass Build()
    {
        return _buildClass;
    }
}