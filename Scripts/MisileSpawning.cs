using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisileSpawning : MonoBehaviour
{
    public GameObject misile;
    private Vector3 spawnpos;

    public float startDelay = 2;
    public float repeatRate = 15;

    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMisile", startDelay, repeatRate);
    }


    void SpawnMisile()
    {
        Instantiate(misile, spawnpos, misile.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        spawnpos = new Vector3 (transform.position.x + 50, transform.position.y, transform.position.z);
    }
}
