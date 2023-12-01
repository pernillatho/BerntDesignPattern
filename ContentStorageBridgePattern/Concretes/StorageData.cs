namespace ContentStorageBridgePattern.Concretes;

public class StorageData
{
    public string ContentName { get; set; }
    public string StorageName { get; set; }

    public StorageData(string contentName, string storageName)
    {
        ContentName = contentName;
        StorageName = storageName;
    }
}