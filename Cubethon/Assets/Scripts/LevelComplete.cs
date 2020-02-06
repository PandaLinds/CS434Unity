using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void replay()
    {
        FindObjectOfType<GameManager>().Restart();
    }

    public void LoadNextLevel()
    {
        CommandLog.commands.Clear();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
