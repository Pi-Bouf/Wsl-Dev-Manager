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
        Console.WriteLine(this.getTaskName() + " not implemented !");
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