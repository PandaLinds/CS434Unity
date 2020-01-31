using UnityEngine;

namespace Pattern.Command_
{
    public class Client : MonoBehaviour
    {
        private Player mPlayer;

        void Start()
        {
            mPlayer = new Player1();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Command moveLeft = new Left(mPlayer);

                Invoker invoker = new Invoker();

                invoker.SetCommand(moveLeft);
                invoker.ExecuteCommand();
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                Command moveRight = new Right(mPlayer);

                Invoker invoker = new Invoker();

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
