//  /Users/tim/Desktop/по ту сторону
Console.WriteLine("enter path");
string path = Console.ReadLine();
if (Directory.Exists(path))
{
    DirectoryInfo di = new DirectoryInfo(path);

    FileInfo[] fiArr = di.GetFiles();
    long b = 0;
    List<string> exst = new List<string>();
    foreach (FileInfo a in fiArr)
    {

        if (!exst.Contains(a.Extension))
        {
            exst.Add(a.Extension);
        }
        b += a.Length;
    }
    int[,] mass = new int[exst.Count(), 2];
    for (int i = 0; i < exst.Count(); i++)
    {
        for (int j = 0; j < 2; j++)
        {
            mass[i, 1] = 0;
        }
    }
    foreach (FileInfo a in fiArr)
    {
        foreach (string name in exst)
        {
            if (a.Extension.Equals(name))
            {
                mass[exst.IndexOf(a.Extension), 1] += 1;
            }
        }
    }

    for (int i = 0; i < exst.Count(); i++)
    {
        for (int j = 0; j < 1; j++)
        {
            Console.Write(exst[mass[i, 0]] + " - " + mass[i, 1]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    string[] podCatalog = Directory.GetDirectories(path);
    Console.WriteLine("size all = " + b + " bites");

    foreach (string a in podCatalog)
    {
        Console.WriteLine(a);
    }

}
else
{
    Console.WriteLine("not exist");
}