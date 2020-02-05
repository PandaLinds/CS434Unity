using UnityEngine;

class Invoker
{
    private Command m_Command;
    public bool disableLog = false;

    //get commands and set to m_Command
    public void SetCommand(Command command)
    {
        m_Command = command;
    }

    //execute command and put command in queue
    public void ExecuteCommand()
    {
        if (!disableLog)
        {
            CommandLog.commands.Enqueue(m_Command);  // log the command for playback later
        }
        Debug.Log(m_Command);
        m_Command.Execute();
    }
}