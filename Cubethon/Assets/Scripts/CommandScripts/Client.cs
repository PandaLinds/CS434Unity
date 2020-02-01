using UnityEngine;

namespace Pattern.Command_
{
    public class Client : MonoBehaviour
    {
        private PlayerGameControls mPlayer;
        Invoker invoker = new Invoker();
        

        void Start()
        {
            mPlayer = new PlayerGameMovement();
            Debug.Log("PlayerMovement created");
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.A))
            {
                Command moveLeft = new Left(mPlayer);
                invoker.SetCommand(moveLeft);
                invoker.ExecuteCommand();
            }

            if (Input.GetKey(KeyCode.D))
            {
                Command moveRight = new Right(mPlayer);
                invoker.SetCommand(moveRight);
                invoker.ExecuteCommand();
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
