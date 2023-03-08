using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelDecrease : MonoBehaviour
{
    private float timeRemaining;
    public float timerMax = 5f;
    public Slider slider;
    public float fuelPickUp;
    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = timerMax;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = CalculateSliderValue();

        if(timeRemaining <= 0)
        {
            timeRemaining = 0;
        }

        else if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
    }

    float CalculateSliderValue()
    {
        return(timeRemaining / timerMax);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Fuel"))
        {
            timeRemaining = timeRemaining + fuelPickUp;
            Destroy(collision.gameObject);
        }
    }
}
