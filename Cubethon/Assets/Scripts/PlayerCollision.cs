using UnityEngine;
using System;

public class PlayerCollision : MonoBehaviour
{
    public static event Action<PlayerCollision> OnPlayerCollision;
    void OnCollisionEnter(Collision collisionInfo)
    {
        //if blocks run into player, add a point then destroy
        if((collisionInfo.collider.tag == "Player")||(collisionInfo.collider.tag == "Obstacal"))
        {
            if (OnPlayerCollision != null)
            {
                OnPlayerCollision(this);
            }
        }
    }

    
}
