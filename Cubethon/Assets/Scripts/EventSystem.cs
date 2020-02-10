using UnityEngine;

//reference from https://www.youtube.com/watch?v=Yy7Dt2usGy0

public class EventSystem : MonoBehaviour
{
    
    private void Start()
    {
        PlayerCollision.OnPlayerCollision += AddToScore;
    }

    private void OnDestroy()
    {
        PlayerCollision.OnPlayerCollision -= AddToScore;
    }
    private void AddToScore(GameObject Obstical)
    {
        Score.scoreNumber++;
        Destroy(Obstical, 0.75f);
    }
}
