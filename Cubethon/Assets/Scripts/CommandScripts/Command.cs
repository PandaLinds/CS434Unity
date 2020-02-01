abstract class Command
{
    protected PlayerGameControls m_Player;

    public Command(PlayerGameControls PlayerNew)
    {
        m_Player = PlayerNew;
    }

    public abstract void Execute();
}