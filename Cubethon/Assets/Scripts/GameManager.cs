using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public GameObject player;
    public float restartDelay = 4f;
    public GameObject completeLevelUI;

    void Start()
    {
        Client playerMovement = FindObjectOfType<Client>();
        player = playerMovement.gameObject;

        // if (CommandLog.commands.Count > 0)
        // {
        //     instantReplay = true;
        //     replayStartTime = Time.timeSinceLevelLoad;
        // }
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Score.scoreNumber = 0;
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
}
