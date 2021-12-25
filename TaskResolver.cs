using Wsl_Dev_Manager.Tasks;

namespace Wsl_Dev_Manager;

public class TaskResolver
{
    public ITask[] tasks;

    public TaskResolver()
    {
        this.tasks = new ITask[]
        {
            new AptUpdate(),
            new AptUpgrade(),
            new AptInstall("yadm")
        };
    }
}