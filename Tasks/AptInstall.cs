using Wsl_Dev_Manager.ProcessExecutor;

namespace Wsl_Dev_Manager.Tasks;

public class AptInstall: ITask
{
    private string what;
    public AptInstall(string what)
    {
        this.what = what;
    }

    public string getTaskName()
    {
        return "AptInstall";
    }

    public string[] getDependencies()
    {
        return new string[] { "AptUpdate" };
    }

    public void execute()
    {
        Logger.Logger.write("AptInstall", "Starting...");
        
        Command c = Command.Apt("install " + what);
        c.execute();
        if (c.failed())
        {
            Logger.Logger.write("AptInstall", "Failed ! " + c.output, ConsoleColor.Red);
            return;
        }
        
        Logger.Logger.write("AptInstall", "Success", ConsoleColor.Green);
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