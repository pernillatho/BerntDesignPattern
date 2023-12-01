using Common;
using ContentStorageBridgePattern.Abstracts;

namespace ContentStorageBridgePattern.Concretes;

public class DatabaseStorage : Storage
{
    public DatabaseStorage(ILogger logger) : base(logger)
    {
    }

    public override void SendToStorage(StorageData storageData)
    {
        _logger.Log($"Storing content {storageData.ContentName}, in database {Name}");
    }
}