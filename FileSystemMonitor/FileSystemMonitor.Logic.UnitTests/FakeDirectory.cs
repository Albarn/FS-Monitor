using FileSystemMonitor.Logic.Dependencies;

namespace FileSystemMonitor.Logic.UnitTests
{
    class FakeDirectory : IDirectory
    {
        public bool IsExist { get; set; }

        public string Path { get; set; }

        public bool Exists()
        {
            return IsExist;
        }
    }
}
