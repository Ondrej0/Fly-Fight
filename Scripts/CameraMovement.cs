using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;

    public Vector3 offeset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player != null)
        {
            Vector3 camPos = transform.position;
            Vector3 desiredPos = player.transform.position;

            Vector3 smoothedPos = Vector3.Lerp(camPos, desiredPos, 0.125f);

            transform.position = new Vector3(smoothedPos.x + 0.7f, transform.position.y, transform.position.z);
        }
    }
}
