using System;

namespace FileSystemMonitor.Logic
{

    public delegate void FSChangedHandler(object sender, FSChangedEventArgs e);

    public class FSChangedEventArgs:EventArgs
    {
        public string message;

        public FSChangedEventArgs(string message):base()
        {
            
            this.message = message;
        }
    }
}
