using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisileCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
   {
        if(collision.gameObject.CompareTag("ground"))
        {
            Destroy(gameObject);
        }
   }
}
