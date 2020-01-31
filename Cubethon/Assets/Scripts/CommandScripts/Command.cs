abstract class Command
{
    protected Player m_Player;

    public Command(Player PlayerNew)
    {
        m_Player = PlayerNew;
    }

    public abstract void Execute();
}