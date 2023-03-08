using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectVerticalMove : MonoBehaviour
{
    public float moveDistance = 20.0f;
    public float bottomDistance = 0.0f;
    public float moveDuration =5.0f;
    private bool isMovingUp = true;
    

    // Update is called once per frame
    void Update()
    {
        if(isMovingUp)
        {
            transform.position += Vector3.up * moveDistance * Time.deltaTime / moveDuration;
            if(transform.position.y >= moveDistance)
            {
                isMovingUp = false;
            }
        }
        else
        {
            transform.position -= Vector3.up * moveDistance * Time.deltaTime / moveDuration;
            if(transform.position.y <= bottomDistance)
            {
                isMovingUp = true;
            }
        }
    }
}
