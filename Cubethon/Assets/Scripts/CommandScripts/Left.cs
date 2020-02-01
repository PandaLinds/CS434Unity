class Left : Command
{
    public Left(PlayerGameControls CurrentPlayer) : base(CurrentPlayer)
    {
    }

    public override void Execute()
    {
        m_Player.Left();
    }
}