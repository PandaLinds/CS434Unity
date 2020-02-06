using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        FindObjectOfType<Client>().forwardForce = 0f;
        FindObjectOfType<Client>().sidewaysForce = 0f;
        gameManager.CompleteLevel();
    }
}
