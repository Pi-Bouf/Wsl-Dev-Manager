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
        throw new NotImplementedException();
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