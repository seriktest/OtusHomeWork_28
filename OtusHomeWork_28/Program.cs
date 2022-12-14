
var rootDir = @"C:\Otus";
var directory =  @"TestDir";
var file = @"TestFile";

var countDir = 2;
var countFile = 10;

try
{
    for (int i = 1; i <= countDir; i++)
    {
        CreateDir(Path.Combine(rootDir, directory) + i);
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

var directoryes = Directory.GetDirectories(rootDir);


try
{
    foreach (var dir in directoryes)
    {
        for (int i = 1; i <= countFile; i++)
        {
            CreateFile(Path.Combine(dir, file) + i, ".txt");
        }
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    throw;
}



foreach (var dir in directoryes)
{
    var files = Directory.GetFiles(dir);
    foreach (var f in files)
    {
        if (!File.Exists(f))
            continue;
        
        using var stream = new StreamReader(Path.Combine(dir, f));
        while (!stream.EndOfStream)
        {
            Console.WriteLine($"Папка: {dir}\nФайл: {f}\nСодержимое : {stream.ReadToEnd()}");
            Console.WriteLine();
        }
    }
}



Console.ReadKey();


void CreateDir(string path)
{
    var dir = new DirectoryInfo(path);

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

void CreateFile(string path, string ext)
{
    var fileName = path + ext;
    
    try
    {
        using var writer = File.CreateText(fileName);
        writer.WriteLine($"{Path.GetFileName(fileName)} \n {DateTime.Now}");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        throw;
    }
}