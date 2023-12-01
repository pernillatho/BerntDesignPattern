using Common;
using ContentStorageBridgePattern.Abstracts;

namespace ContentStorageBridgePattern.Concretes;

public class CloudStorage : Storage
{
    public CloudStorage(ILogger logger) : base(logger)
    {
    }

    public override void SendToStorage(StorageData storageData)
    {
        _logger.Log($"Storing content {storageData.ContentName}, in cloud {storageData.StorageName}");
    }
}