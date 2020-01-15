using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    public static int scoreNumber;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreNumber.ToString();
    }

    
}
