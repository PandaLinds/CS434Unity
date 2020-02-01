class Right : Command
{
    public Right(PlayerGameControls player) : base(player)
    {
    }

    public override void Execute()
    {
        m_Player.Right();
    }
}