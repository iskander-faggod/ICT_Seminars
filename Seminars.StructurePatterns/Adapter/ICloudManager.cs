namespace Seminars.StructurePatterns.Adapter;

// класс, реализующий методы облачное хранилище - аналог Google/Yandex Disk
public interface ICloudManager
{
    void SaveData()
    {
        Console.WriteLine("Специальынй метод сохранения данных в облако");
    }
    
    void GetData()
    {
        Console.WriteLine("Специальынй метод получения данных с облака");
    }
}