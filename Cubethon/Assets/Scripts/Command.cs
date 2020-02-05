using UnityEngine;

public abstract class Command
{
    public Rigidbody _player;
    public float _force;
    public abstract void Execute();
}

//left command
class Left : Command
{
    //get rigidobdy from player and force
    public Left(Rigidbody player, float force)
    {
        _player = player;
        _force = force;
    }

    //add force to player
    public override void Execute()
    {
        _player.AddForce(-_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}

class Right : Command
{
    //get rigidobdy from player and force
    public Right(Rigidbody player, float force)
    {
        _player = player;
        _force = force;
    }

    //add force to player
    public override void Execute()
    {
        _player.AddForce(_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}