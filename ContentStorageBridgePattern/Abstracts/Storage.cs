using Common;
using ContentStorageBridgePattern.Concretes;
using ContentStorageBridgePattern.Interfaces;

namespace ContentStorageBridgePattern.Abstracts
{
    public abstract class Storage : IStorage
    {
        protected ILogger _logger { get; set; }
        public string Name { get; set; }

        public Storage(ILogger logger)
        {
            _logger = logger;
        }

        public abstract void SendToStorage(StorageData storageData);
    }
}

