namespace Seminars.StructurePatterns.Adapter;

// наш адаптер делегирует выполнение метода сохранения на наш ICloudManager
public class DataAdapter : IFileManager
{
    private readonly ICloudManager _cloudManager;

    public DataAdapter(ICloudManager cloudManager)
    {
        _cloudManager = cloudManager;
    }
    
    public void SaveData()
    {
        _cloudManager.GetData();
        _cloudManager.SaveData();
    }
}