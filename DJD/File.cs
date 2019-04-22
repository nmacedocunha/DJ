using System;
using System.IO;

namespace DJD.IO
{
    public class File
    {
        // Just some example of IO to put in here using System.IO as base.
        public void Write(string[] text, string fileName)
        {
            using (var file = new StreamWriter(fileName))
            {
                foreach (var line in text)
                {
                    file.WriteLine(line);
                }
            }
        }
    }
}
