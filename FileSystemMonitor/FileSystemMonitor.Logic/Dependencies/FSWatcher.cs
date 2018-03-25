using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemMonitor.Logic.Dependencies
{
    public class FSWatcher : IWatcher
    {
        FileSystemWatcher watcher;

        public FSWatcher()
        {
            watcher = new FileSystemWatcher();
        }

        public string Path
        {
            get => watcher.Path;
            set => watcher.Path = value;

        }

        public bool IncludeSubdirectories {
            get => watcher.IncludeSubdirectories;
            set => watcher.IncludeSubdirectories = value;
        }
        public bool EnableRaisingEvents {
            get => watcher.EnableRaisingEvents;
            set => watcher.EnableRaisingEvents = value;
        }

        public void SubscribeChanged(FileSystemEventHandler handler)
        {
            watcher.Changed += handler;
        }

        public void SubscribeCreated(FileSystemEventHandler handler)
        {
            watcher.Created += handler;
        }

        public void SubscribeDeleted(FileSystemEventHandler handler)
        {
            watcher.Deleted += handler;
        }

        public void SubscribeError(ErrorEventHandler handler)
        {
            watcher.Error += handler;
        }

        public void SubscribeRenamed(RenamedEventHandler handler)
        {
            watcher.Renamed += handler;
        }
    }
}
