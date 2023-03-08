using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    public float Acceleration;

    private bool isCoolDown = false;
    public bool superSpeed = true;
    public float coolDown = 3f;

    Rigidbody2D rb;

    public float RotationControl;

    float MovY, MovX = 1;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovY = Input.GetAxis("Vertical");

//This checks for super speed
        if(isCoolDown == false)
        {
            if(Input.GetKeyDown(KeyCode.D))
            {
                Speed = Speed * 20;
                Acceleration = Acceleration * 100;

                StartCoroutine(CoolDown());    
            }
        }
    }

    IEnumerator CoolDown()
    {
        isCoolDown = true;
        yield return new WaitForSeconds(coolDown);
        Speed = Speed / 20;
        Acceleration = Acceleration / 100;
        yield return new WaitForSeconds(coolDown);
        isCoolDown = false;
    }

    

    private void FixedUpdate()
    {
        Vector2 Velocity = transform.right * (MovX * Acceleration);

        rb.AddForce(Velocity);

        float Direction = Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.right));

        if (Acceleration > 0)
        {
            if(Direction > 0)
            {
                rb.rotation += MovY * RotationControl * (rb.velocity.magnitude/Speed);
            }
            else 
            {
                rb.rotation -= MovY * RotationControl *(rb.velocity.magnitude/Speed);
            }
        }

        float thrustForce = Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.down)) * 2.0f;

        Vector2 relForce = Vector2.up * thrustForce;

        rb.AddForce(rb.GetRelativeVector(relForce));

        if(rb.velocity.magnitude > Speed)
        {
            rb.velocity = rb.velocity.normalized * Speed;
        }

        
        
       
        
    }

    public void AdjustSpeed(float NewSpeed)
    {
        if(NewSpeed == 0)
        {
            rb.gravityScale = 3.0f;
            Acceleration = Acceleration/6;
        }
    }

     private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Fuel"))
        {
            if(rb.gravityScale == 3.0f)
            {
                rb.gravityScale = 0;
                Acceleration = Acceleration * 6;
            }
        }
    }
}
