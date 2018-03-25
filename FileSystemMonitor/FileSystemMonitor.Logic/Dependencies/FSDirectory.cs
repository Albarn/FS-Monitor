using System.IO;

namespace FileSystemMonitor.Logic.Dependencies
{
    class FSDirectory : IDirectory
    {
        public string Path { get; set; }

        public bool Exists()
        {
            return Directory.Exists(Path);
        }
    }
}
