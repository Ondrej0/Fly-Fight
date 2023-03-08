using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
   {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("MainGame");
        }

        if(collision.gameObject.CompareTag("ground"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("MainGame");
        }

        if(collision.gameObject.CompareTag("BigEnemy"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("MainGame");
        }

        if(collision.gameObject.CompareTag("Finnish"))
        {
            SceneManager.LoadScene("YouWon");
        }

        
   }
}
