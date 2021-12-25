namespace Wsl_Dev_Manager.Tasks;

public interface ITask
{
    public string getTaskName();

    public string[] getDependencies();

    public void execute();

    public void logError();

    public void logInfo();
}