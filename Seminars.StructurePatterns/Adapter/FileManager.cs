namespace Seminars.StructurePatterns.Adapter;

public class DataManager : IFileManager
{
    
    public void SaveData()
    {
        Console.WriteLine("Специальынй метод для сохранения данных в нашу файловую систему");
    }
}