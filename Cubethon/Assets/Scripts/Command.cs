using UnityEngine;

public abstract class Command
{
    public Rigidbody mplayer;
    public float mforce;
    public float timestamp;
    public abstract void Execute();
}

//left command
class Left : Command
{
    //get rigidobdy from player and force
    public Left(Rigidbody player, float force)
    {
        mplayer = player;
        mforce = force;
    }

    //add force to player
    public override void Execute()
    {
        timestamp = Time.timeSinceLevelLoad;
        mplayer.AddForce(-mforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}

class Right : Command
{
    //get rigidobdy from player and force
    public Right(Rigidbody player, float force)
    {
        mplayer = player;
        mforce = force;
    }

    //add force to player
    public override void Execute()
    {
        timestamp = Time.timeSinceLevelLoad;
        mplayer.AddForce(mforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}