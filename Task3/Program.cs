 
using Task3;
using System.IO;

// Choose a safe file path
string fileName = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
    "testfile.txt"
);

// Append some text to the file
File.AppendAllText(fileName, "This is some appended text asdfdsafdsa fdsaf dsaf jwiukf klwiujkwekjewkje asdf iumx, oewoiwl ,xniwujenbdtewkejw.\n");

FileReader reader = new FileReader();
reader.Read(fileName);
