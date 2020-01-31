class Left : Command
{
    public Left(Player CurrentPlayer) : base(CurrentPlayer)
    {
    }

    public override void Execute()
    {
        m_Player.Left();
    }
}