using UnityEngine;

//reference from https://www.youtube.com/watch?v=Yy7Dt2usGy0

public class EventSystem : MonoBehaviour
{
    
    
    private void Start()
    {
        PlayerCollision.OnPlayerCollision += Pts;
        PlayerCollision.OnPlayerCollisionPlayer += ColorChange;
    }

    private void OnDestroy()
    {
        PlayerCollision.OnPlayerCollision -= Pts;
        PlayerCollision.OnPlayerCollisionPlayer -= ColorChange;
    }

    private void Pts(GameObject Obstical)
    {
        if (Obstical.tag == "Normal")
        {
            Score.scoreNumber++;
            Destroy(Obstical, 0.75f);
        }
        else if (Obstical.tag == "Extra Points")
        {
            Score.scoreNumber+=5;
            Destroy(Obstical, 0.75f);
        }
        else if (Obstical.tag == "Obstacle")
        {
            Score.scoreNumber--;
            Destroy(Obstical, 0.75f);
        }
    }

    public Material OrigPlayerMat;
    public Material NewPlayerMat;
    private void ColorChange(GameObject Player)
    {
        Debug.Log("Color Change");
        if (Player.GetComponent<MeshRenderer>().material.color == OrigPlayerMat.color)
        {
            Debug.Log("mat is playermat");
            Player.GetComponent<MeshRenderer>().material = NewPlayerMat;
        }        
        else if(Player.GetComponent<MeshRenderer>().material.color == NewPlayerMat.color)
        {
            Debug.Log("mat is other");
            Player.GetComponent<MeshRenderer>().material = OrigPlayerMat;
        }
    }
}
