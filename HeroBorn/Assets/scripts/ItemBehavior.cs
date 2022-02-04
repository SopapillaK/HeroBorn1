using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "player")
        {
            Destroy(this.transform.parent.gameObject);
            Debug.Log("Item collected!");
        }
    }
}
