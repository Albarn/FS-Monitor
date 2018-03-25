using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemMonitor.Logic.Dependencies
{
    public interface IWatcher
    {
        void SubscribeError(ErrorEventHandler handler);
        void SubscribeChanged(FileSystemEventHandler handler);
        void SubscribeRenamed(RenamedEventHandler handler);
        void SubscribeCreated(FileSystemEventHandler handler);
        void SubscribeDeleted(FileSystemEventHandler handler);

        bool IncludeSubdirectories { get; set; }
        bool EnableRaisingEvents { get; set; }

        string Path { get; set; }
    }
}
