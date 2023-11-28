using System;
using System.IO;

public class Explorer
{
    private static string currentPath;

    public static void ShowDrives()
    {
        DriveInfo[] drives = DriveInfo.GetDrives();
        foreach (var drive in drives)
        {
            Console.WriteLine($"Drive: {drive.Name}, Free: {drive.TotalFreeSpace / (1024 * 1024 * 1024)} GB, Total: {drive.TotalSize / (1024 * 1024 * 1024)} GB");
        }
    }

    public static void ShowCurrentDirectoryInfo()
    {
        Console.WriteLine($"Current Directory: {currentPath}");
        
    }

    public static void ShowContent()
    {
        
    }

    public static void NavigateToDirectory(string directory)
    {
        
        currentPath = directory;
    }

    public static void RunFile(string filePath)
    {
       
    }
}

public class ArrowNavigation
{
    public static void HandleKeyPress(ConsoleKeyInfo key, ref int selectedIndex, int maxIndex)
    {
        switch (key.Key)
        {
            case ConsoleKey.UpArrow:
                MoveUp(ref selectedIndex, maxIndex);
                break;
            case ConsoleKey.DownArrow:
                MoveDown(ref selectedIndex, maxIndex);
                break;
            case ConsoleKey.Enter:
                SelectOption(selectedIndex);
                break;
            case ConsoleKey.Escape:
                
                break;
        }
    }

    private static void MoveUp(ref int selectedIndex, int maxIndex)
    {
      
    }

    private static void MoveDown(ref int selectedIndex, int maxIndex)
    {
      
    }

    private static void SelectOption(int selectedIndex)
    {
  
    }
}

class Program
{
    static void Main()
    {
    
    }
}
