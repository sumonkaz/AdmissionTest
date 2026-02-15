using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class FileReader
    {
        public void Read(string fileName)
        {
            // Create the file if it does not exist
            if (!File.Exists(fileName))
            {
                using (var fs = File.Create(fileName))
                {
                    // Optionally, fill with 200 bytes for demonstration
                    byte[] data = new byte[200];
                    new Random().NextBytes(data);
                    fs.Write(data, 0, data.Length);
                }
            }

            // Read the 100th byte
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                if (fs.Length < 100)
                {
                    Console.WriteLine("File does not have 100 bytes.");
                    return;
                }

                fs.Seek(99, SeekOrigin.Begin); // 0-based index
                int value = fs.ReadByte();
                if (value != -1)
                    Console.WriteLine($"100th byte character: {(char)value}");
                else
                    Console.WriteLine("Could not read the 100th byte.");

            }
        }
    }
}
