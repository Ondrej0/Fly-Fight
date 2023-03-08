using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCounter : MonoBehaviour
{
    public float lifeCounter = 3;
    public SpriteRenderer spriteRenderer;
    private float dyingColor = 0.6f;

   void Start()
   {
    spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
   }

    void Update()
    {
        if(lifeCounter <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            lifeCounter -= 1;
            spriteRenderer.color = new Color(dyingColor, dyingColor, dyingColor, 1.0f);
            dyingColor -= 0.3f;

            Destroy(collision.gameObject);
        }
    }
}
