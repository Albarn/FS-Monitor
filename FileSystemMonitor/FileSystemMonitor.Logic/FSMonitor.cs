using FileSystemMonitor.Logic.Dependencies;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileSystemMonitor.Logic
{
    public class FSMonitor
    {
        IWatcher watcher;
        IDirectory directory;

        public List<string> log;
        
        public event ErrorEventHandler Error;
        public event FSChangedHandler Changed;

        public FSMonitor(string path, IWatcher watcher=null, 
            IDirectory directory=null)
        {
            log = new List<string>();
            log.Add($"[{DateTime.Now.ToString("HH:mm")}]" + 
                " лог монитора директории " + path);

            if (watcher == null) watcher = new FSWatcher();
            if (directory == null) directory = new FSDirectory();

            this.watcher = watcher;
            this.directory = directory;

            watcher.Path = path;
            directory.Path = path;

            watcher.SubscribeError(Watcher_Error);
            watcher.SubscribeChanged(Watcher_Changed);
            watcher.SubscribeRenamed(Watcher_Renamed);
            watcher.SubscribeCreated(Watcher_Created);
            watcher.SubscribeDeleted(Watcher_Deleted);

            watcher.IncludeSubdirectories = true;
        }

        public void Start()
        {
            if (directory.Exists())
            {
                watcher.EnableRaisingEvents = true;
                log.Add($"[{DateTime.Now.ToString("HH:mm")}]" +
                    " запуск монитора");
            }
            else
            {
                throw new DirectoryNotFoundException();
            }
        }

        public void Stop()
        {
            watcher.EnableRaisingEvents = false;
            log.Add($"[{DateTime.Now.ToString("HH:mm")}]" +
                    " остановка монитора");
        }

        public void SaveLogToFile(string path)
        {
            StreamWriter writer = new StreamWriter(
                       new FileStream(path, FileMode.Create));
            try
            {
                foreach (string line in log)
                    writer.WriteLine(line);
            }
            finally
            {
                writer.Close();
            }
            
        }

        private void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            FSChangedEventArgs args = new FSChangedEventArgs(
                $"[{DateTime.Now.ToString("HH:mm")}]"+
                $" файл {e.FullPath.Substring(watcher.Path.Length+1)}"+
                $" был удален");
            log.Add(args.message);
            Changed(sender, args);
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            FSChangedEventArgs args = new FSChangedEventArgs(
                   $"[{DateTime.Now.ToString("HH:mm")}]" +
                   $" создан файл {e.FullPath.Substring(watcher.Path.Length+1)}");
            log.Add(args.message);
            Changed(sender, args);
        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            FSChangedEventArgs args = new FSChangedEventArgs(
                   $"[{DateTime.Now.ToString("HH:mm")}]" +
                   $" файл {e.OldFullPath.Substring(watcher.Path.Length+1)}" +
                   $" был переименован на {e.Name}");
            log.Add(args.message);
            Changed(sender, args);
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            FSChangedEventArgs args = new FSChangedEventArgs(
                   $"[{DateTime.Now.ToString("HH:mm")}]" +
                   $" файл {e.FullPath.Substring(watcher.Path.Length+1)}" +
                   $" был изменен");
            log.Add(args.message);
            Changed(sender, args);
        }

        private void Watcher_Error(object sender, ErrorEventArgs e)
        {
            log.Add(e.GetException().Message);
            Error(sender, e);
        }
    }
}
