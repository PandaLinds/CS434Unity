using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public GameObject player;
    public float restartDelay = 4f;
    public GameObject completeLevelUI;
    bool instantReplay = false;

    void Start()
    {
        Client playerMovement = FindObjectOfType<Client>();
        player = playerMovement.gameObject;

        Score.scoreNumber = 0;
        if (CommandLog.commands.Count > 0)
        {
            //set instant replay on and give start time
            instantReplay = true;
            //replayStartTime = Time.timeSinceLevelLoad;
        }
    }

    private void Update()
    {
        if(instantReplay)
        {
            InstantReplay();
        }
    }

    public void CompleteLevel()
    {  // need a button for replay option
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Score.scoreNumber = 0;
    }

    void InstantReplay()
    {
        
        if (CommandLog.commands.Count == 0)
        {
            CommandLog.commands.Clear();
            instantReplay = false;
            return;
        }

        Command command;// = CommandLog.commands.Peek();
        command = CommandLog.commands.Dequeue();
        Debug.Log(CommandLog.commands.Count);
        command._player = player.GetComponent<Rigidbody>();
        Invoker invoker = new Invoker();
        invoker.disableLog = true;
        invoker.SetCommand(command);
        invoker.ExecuteCommand();

    }
}
