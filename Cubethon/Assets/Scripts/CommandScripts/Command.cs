using UnityEngine;

abstract class Command
{
    public Rigidbody _player;
    public float _force;
    public float timestamp; // for logging purposes
    public abstract void Execute();
}

class Left : Command
{
    public Left(Rigidbody player, float force)
    {
        _player = player;
        _force = force;
    }

    public override void Execute()
    {
        timestamp = Time.timeSinceLevelLoad;
        _player.AddForce(-_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}

class Right : Command
{
    public Right(Rigidbody player, float force)
    {
        _player = player;
        _force = force;
    }

    public override void Execute()
    {
        _player.AddForce(_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}