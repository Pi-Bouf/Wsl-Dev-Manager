namespace Wsl_Dev_Manager.Logger;

public class Logger
{
    public static void write(string message, string more = null, ConsoleColor moreColor = ConsoleColor.Cyan)
    {
        DateTime localDate = DateTime.Now;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("[");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(localDate.Hour + ":" + localDate.Minute + ":" + localDate.Second);

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("]");
        
        Console.Write(" ==> ");
        
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(message);

        if (more != null)
        {
            Console.CursorLeft = 50;
            Console.ForegroundColor = moreColor;
            Console.Write("► " + more);
        }
        Console.WriteLine("");
    }
}