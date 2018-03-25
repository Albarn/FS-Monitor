using FileSystemMonitor.Logic.Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
