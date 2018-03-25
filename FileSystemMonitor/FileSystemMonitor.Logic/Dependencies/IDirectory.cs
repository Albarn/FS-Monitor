namespace FileSystemMonitor.Logic.Dependencies
{
    public interface IDirectory
    {
        string Path { get; set; }
        bool Exists();
    }
}
