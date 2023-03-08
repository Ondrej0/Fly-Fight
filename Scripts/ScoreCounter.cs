using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreCounter : MonoBehaviour
{
    public float score = 0;
    public TextMeshProUGUI scoreDisplay;

    

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Score"))
        {
            score += 1;
            Destroy(collision.gameObject);
        }
    }

}
