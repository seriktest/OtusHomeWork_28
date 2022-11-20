var pathDir = @"C:\Otus\TestDir";
var pathFile = Path.Combine(pathDir, "TestFile");

var countDir = 2;
var countFile = 10;

for (int i = 1; i <= countDir; i++)
{
    CreateDir(pathDir, i.ToString());
}

for (int i = 1; i <= countFile; i++)
{
    CreateFile(pathFile, i.ToString(), ".txt");
}


Console.ReadKey();


void CreateDir(string path, string name)
{
    var dir = new DirectoryInfo(Path.Combine(path, name));

    try
    {
        dir.Create();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        throw;
    }
}

void CreateFile(string path, string name, string ext)
{
    var file = Path.Combine(path, name + ext);
    
    try
    {
        File.Create(file);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        throw;
    }
}