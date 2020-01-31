using UnityEngine;

class Player1 : Player
{
    //add force
    public override void Right()
    {
        Debug.Log("Right");
    }

    public override void Left()
    {
        Debug.Log("Left");
    }
}