using ContentStorageBridgePattern.Concretes;

namespace ContentStorageBridgePattern.Interfaces
{
    internal interface IStorage
    {
        void SendToStorage(StorageData storageData);
    }
}
