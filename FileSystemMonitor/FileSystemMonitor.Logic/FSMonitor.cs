using System;
using System.Collections.Generic;
using System.IO;

namespace FileSystemMonitor.Logic
{
    public class FSMonitor
    {
        FileSystemWatcher watcher;

        public List<string> log;
        
        public event ErrorEventHandler Error;
        public event FSChangedHandler Changed;

        public FSMonitor(string path)
        {
            log = new List<string>();
            log.Add($"[{DateTime.Now.ToString("HH:mm")}]" + 
                " лог монитора директории " + path);

            watcher =new FileSystemWatcher(path);

            watcher.Error += Watcher_Error;
            watcher.Changed += Watcher_Changed;
            watcher.Renamed += Watcher_Renamed;
            watcher.Created += Watcher_Created;
            watcher.Deleted += Watcher_Deleted;

            watcher.IncludeSubdirectories = true;
        }

        public void Start()
        {
            if (Directory.Exists(watcher.Path))
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
