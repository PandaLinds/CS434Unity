//https://github.com/bslease/Cubethon_Demo/tree/master/Cubethon%20Demo%20Project/Assets/Scripts

class Invoker
{
    private Command m_Command;
    public bool disableLog = false;

    public void SetCommand(Command command)
    {
        m_Command = command;
    }

    public void ExecuteCommand()
    {
        if(!disableLog)
        {
            CommandLog.commands.Enqueue(m_Command);
        }
        m_Command.Execute();
    }
}