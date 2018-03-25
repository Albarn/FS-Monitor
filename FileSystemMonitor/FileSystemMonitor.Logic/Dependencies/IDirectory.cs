using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemMonitor.Logic.Dependencies
{
    public interface IDirectory
    {
        string Path { get; set; }
        bool Exists();
    }
}
