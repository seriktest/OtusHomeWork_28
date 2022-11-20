





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

void CreateFile(string path, string name)
{
    var file = Path.Combine(path, name);
    
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