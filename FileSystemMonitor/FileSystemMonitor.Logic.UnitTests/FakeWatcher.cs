using FileSystemMonitor.Logic.Dependencies;
using System.IO;

namespace FileSystemMonitor.Logic.UnitTests
{
    class FakeWatcher : IWatcher
    {
        public bool IncludeSubdirectories { get; set; }
        public bool EnableRaisingEvents { get; set; }
        public string Path { get; set; }

        public void SubscribeChanged(FileSystemEventHandler handler)
        {

        }

        public void SubscribeCreated(FileSystemEventHandler handler)
        {

        }

        public void SubscribeDeleted(FileSystemEventHandler handler)
        {

        }

        public void SubscribeError(ErrorEventHandler handler)
        {

        }

        public void SubscribeRenamed(RenamedEventHandler handler)
        {

        }
    }
}
