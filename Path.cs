using System;
using System.Linq;

public class Path
{
    public string CurrentPath { get; private set; }

    public Path(string path)
    {
        this.CurrentPath = path;
    }

    public void Cd(string newPath)
    {
        var newPathList = newPath.Split('/').ToList();

        if (newPathList[0] == ".."){
            newPathList.RemoveAt(0);
            CurrentPath = CurrentPath.Remove(CurrentPath.LastIndexOf('/'));
        }

        CurrentPath += "/" + string.Join('/', newPathList);
    }
}