using System.Diagnostics;

namespace Wsl_Dev_Manager.ProcessExecutor;

public class Command
{
    private string exe;
    private string arguments;
    private string output;
    private string error;
    private int exitCode;
    public Command(string exe, string arguments)
    {
        this.exe = exe;
        this.arguments = arguments;
    }

    public void execute()
    {
        Process p = new Process();
        p.StartInfo.FileName = this.exe;
        p.StartInfo.Arguments = this.arguments;
        p.StartInfo.UseShellExecute = false;
        p.StartInfo.RedirectStandardOutput = true;
        p.StartInfo.RedirectStandardError = true;
        p.Start();
        
        this.output += p.StandardOutput.ReadToEnd();
        this.error += p.StandardError.ReadToEnd();
        
        p.WaitForExit();
        this.exitCode = p.ExitCode;
    }

    public bool failed()
    {
        return this.exitCode != 0;
    }

    public static Command Apt(string arguments)
    {
        return new Command("/usr/bin/apt-get", arguments);
    }
}