using Wsl_Dev_Manager.Tasks;

namespace Wsl_Dev_Manager;

public class TaskExecutor
{
    private ITask[] tasks;

    public TaskExecutor()
    {
        this.tasks = new ITask[]
        {
            new AptUpdate(),
            new AptUpgrade(),
            new AptInstall("yadm")
        };
    }

    public void execute()
    {
        for (int i = 0; i < this.tasks.Length; i++)
        {
            this.tasks[i].execute();
        }
    }
}