using Wsl_Dev_Manager.ProcessExecutor;

namespace Wsl_Dev_Manager.Tasks;

public class AptUpgrade : ITask
{
    public string getTaskName()
    {
        return "AptUpgrade";
    }

    public string[] getDependencies()
    {
        return new string[] {"AptUpdate"};
    }

    public void execute()
    {
        Logger.Logger.write("AptUpgrade", "Starting...");
        
        Command c = Command.Apt("upgrade");
        c.execute();
        if (c.failed())
        {
            Logger.Logger.write("AptUpgrade", "Failed ! " + c.output, ConsoleColor.Red);
            return;
        }
        
        Logger.Logger.write("AptUpgrade", "Success", ConsoleColor.Green);
    }

    public void logError()
    {
        throw new NotImplementedException();
    }

    public void logInfo()
    {
        throw new NotImplementedException();
    }
}