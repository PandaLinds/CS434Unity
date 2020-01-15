using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Player")
        {
            Score.scoreNumber++;
            Destroy(gameObject,0.75f);
        }
    }
}
