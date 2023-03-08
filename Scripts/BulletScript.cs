using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BulletScript : MonoBehaviour
{
    public float life = 3;
    
    


   void Awake()
   {
    Destroy(gameObject, life);
   }

   private void OnTriggerEnter2D(Collider2D collision)
   {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }
   }

   
}
