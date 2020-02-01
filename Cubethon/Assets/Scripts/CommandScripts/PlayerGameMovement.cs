using UnityEngine;

class PlayerGameMovement : PlayerGameControls
{
    GameObject player;
    Rigidbody PlayerRB;
    private float sidewaysForce = 100f;
    public PlayerGameMovement () 
    {
        player = GameObject.Find("player");
        Debug.Log("Player Found");
        PlayerRB = player.GetComponent<Rigidbody>() as Rigidbody;
        Debug.Log("PlayerRB Created");
    }
    //add force
    public override void Right()
    {
        PlayerRB.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        Debug.Log("Right");
    }

    public override void Left()
    {
        
        PlayerRB.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        Debug.Log("Left");
    }
}