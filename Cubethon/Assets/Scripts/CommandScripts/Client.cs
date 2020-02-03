using UnityEngine;

//move getting player and info to here

namespace Pattern.Command_
{
    public class Client : MonoBehaviour
    {
        public Rigidbody rb;
        public float forwardForce = 2000f;
        public float sidewaysForce = 500f;
        GameManager gameManager;
        Invoker invoker = new Invoker();
        

        void Start()
        {
            gameManager = FindObjectOfType<GameManager>();
        }

        void FixedUpdate()
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
            if (Input.GetKey(KeyCode.A))  //Move Left
            {
                Command moveLeft = new Left(rb, sidewaysForce);
                invoker.SetCommand(moveLeft);
                invoker.ExecuteCommand();
            }

            if (Input.GetKey(KeyCode.D)) //Move Right
            {
                Command moveRight = new Right(rb, sidewaysForce);
                invoker.SetCommand(moveRight);
                invoker.ExecuteCommand();
            }

            if (rb.position.y < -1f)
            {
                FindObjectOfType<GameManager>().EndGame();
            }
        }

        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 500, 20), "Press A to move left");
            GUI.Label(new Rect(10, 30, 500, 20), "Press D to move Right");
        }
    }
}
