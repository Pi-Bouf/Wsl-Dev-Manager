using System.Diagnostics;

namespace Wsl_Dev_Manager.ProcessExecutor;

public class Command
{
    private string exe;
    private string arguments;
    public string output;
    private int exitCode;
    public Command(string exe, string arguments)
    {
        this.exe = exe;
        this.arguments = arguments;
        this.output = "";
    }

    public void execute()
    {
        string processOut = "";
        Process p = new Process();
        p.StartInfo.FileName = this.exe;
        p.StartInfo.Arguments = this.arguments;
        p.StartInfo.UseShellExecute = false;
        p.StartInfo.RedirectStandardOutput = true;
        p.StartInfo.RedirectStandardError = true;
        p.Start();
        
        processOut += p.StandardOutput.ReadToEnd();
        processOut += p.StandardError.ReadToEnd();

        p.WaitForExit();

        this.output = processOut;
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