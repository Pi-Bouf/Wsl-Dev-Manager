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