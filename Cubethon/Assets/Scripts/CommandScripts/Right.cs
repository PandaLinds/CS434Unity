class Right : Command
{
    public Right(Player CurrentPlayer) : base(CurrentPlayer)
    {
    }

    public override void Execute()
    {
        m_Player.Right();
    }
}