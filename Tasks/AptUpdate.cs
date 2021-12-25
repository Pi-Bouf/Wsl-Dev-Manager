using Wsl_Dev_Manager.ProcessExecutor;

namespace Wsl_Dev_Manager.Tasks;

public class AptUpdate : ITask
{
    public string getTaskName()
    {
        return "AptUpdate";
    }

    public string[] getDependencies()
    {
        return new string[] {};
    }

    public void execute()
    {
        Logger.Logger.write("AptUpdate", "Starting...");
        
        Command c = Command.Apt("update");
        c.execute();
        if (c.failed())
        {
            Logger.Logger.write("AptUpdate", "Failed ! " + c.output, ConsoleColor.Red);
            return;
        }
        
        Logger.Logger.write("AptUpdate", "Success", ConsoleColor.Green);
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