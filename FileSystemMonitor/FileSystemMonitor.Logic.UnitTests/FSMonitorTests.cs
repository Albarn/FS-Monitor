using NUnit.Framework;
using System.IO;

namespace FileSystemMonitor.Logic.UnitTests
{
    public class FSMonitorTests
    {
        FSMonitor SUT;
        FakeWatcher watcher;
        FakeDirectory directory;

        [SetUp]
        public void SetUp()
        {
            watcher = new FakeWatcher();
            directory = new FakeDirectory();
            SUT = new FSMonitor("", watcher, directory);
        }

        [Test]
        public void Start_DirectoryExists_EnableRaisingEventsShouldBeTrue()
        {
            directory.IsExist = true;
            SUT.Start();
            Assert.True(watcher.EnableRaisingEvents);
        }

        [Test]
        public void Start_DirectoryNotExist_ThrowsDirectoryNotFoundException()
        {
            directory.IsExist = false;
            Assert.Throws<DirectoryNotFoundException>(() => this.SUT.Start());
        }

        [Test]
        public void Stop_NormalState_EnableRaisingEventsShouldBeFalse()
        {
            SUT.Stop();
            Assert.False(watcher.EnableRaisingEvents);
        }
    }
}
