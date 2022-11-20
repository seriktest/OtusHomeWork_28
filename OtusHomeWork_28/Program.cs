





void CreateDir(string path, string name, int count)
{
    var dir = new DirectoryInfo(Path.Combine(path, name));
    for (int i = 0; i < count; i++)
    {
        dir.Create();
    }
}