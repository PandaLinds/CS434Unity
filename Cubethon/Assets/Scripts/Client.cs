using UnityEngine;


public class Client : MonoBehaviour
{
    //get rigid body from console
    public Rigidbody rb;

    //make force
    private float forwardForce = 65f;
    private float sidewaysForce = 165f;

    //make variable for game manager
    GameManager gameManager;

    //make new invoker
    Invoker invoker = new Invoker();


    void Start()
    {
        //find gamemanager from scene
        gameManager = FindObjectOfType<GameManager>();
    }

    void FixedUpdate()
    {
        //forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        
        //move left though invoker
        if (Input.GetKey(KeyCode.A))
        {
            Command moveLeft = new Left(rb, sidewaysForce);
            invoker.SetCommand(moveLeft);
            invoker.ExecuteCommand();
        }

        //move right though invoker
        if (Input.GetKey(KeyCode.D)) 
        {
            Command moveRight = new Right(rb, sidewaysForce);
            invoker.SetCommand(moveRight);
            invoker.ExecuteCommand();
        }

        //game over if player falls
        if (rb.position.y < -1f)
        {
            gameManager.EndGame();
        }
    }

    //game instructions
    void OnGUI()
    {
        GUI.color = Color.black;
        GUI.Label(new Rect(10, 10, 500, 20), "RUN INTO THE BALLS!");
        GUI.Label(new Rect(10, 30, 500, 20), "Press A to move left");
        GUI.Label(new Rect(10, 50, 500, 20), "Press D to move Right");
    }
}
