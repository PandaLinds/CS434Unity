using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public static int scoreNumber;
    void Update()
    {
        Debug.Log(scoreNumber);
        //have score text update to score number
        scoreText.text = scoreNumber.ToString();
    }

    
}
