using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 20;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime *speed);
        
        if(transform.position.x <= -20)
        {
            Destroy(gameObject);
        }
    }
}
