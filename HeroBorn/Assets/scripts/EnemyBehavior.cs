using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.name == "player")
        {
            Debug.Log("Player detected - attack!");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.name == "player")
        {
            Debug.Log("Player out of range, resume patrol");
        }
    }
}
