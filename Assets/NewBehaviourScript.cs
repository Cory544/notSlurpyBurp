using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public Vector2 cachedVelocity;
    public float flapStrength;
    public float flapStrength1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.velocity = new Vector2(0.99999f * myRigidbody.velocity.x, myRigidbody.velocity.y);                   //myRigidbody.velocity - 0.9 * myRigidbody.velocity;

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = myRigidbody.velocity + Vector2.up * flapStrength;
        }
        //if (Event.keyCode(KeyCode.A) == true)
        {
           // myRigidbody.velocity = myRigidbody.velocity + Vector2.left * flapStrength1;
        }
       // if (Event.keyCode(KeyCode.D) == true)
        {
          //  myRigidbody.velocity = myRigidbody.velocity + Vector2.right * flapStrength1;
        }
       // if (Event.keyCode(KeyCode.LeftShift) == true)
        {
           // myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y);
        }
    }
    void OnGUI()
    {
        Event m_Event = Event.current;

        if (m_Event.type == EventType.KeyDown)
        {
            Debug.Log("Mouse Down.");
            if (m_Event.character == 'a')
            {
                myRigidbody.velocity = new Vector2(-2f, myRigidbody.velocity.y);            //myRigidbody.velocity + Vector2.left * flapStrength1;
            }
            else
            {
                myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y);
            }
            if (m_Event.character == 'd')
            {
                myRigidbody.velocity = myRigidbody.velocity + Vector2.right * flapStrength1;
            }

        }
    }
    void FixedUpdate()
    {
        cachedVelocity = myRigidbody.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //myRigidbody.velocity.y = myRigidbody.velocity.y * -1;
        //myRigidbody.velocity = cachedVelocity * -0.5; //-collision.impulse; // -cachedVelocity;
        myRigidbody.velocity = new Vector2(cachedVelocity.x, -0.8f * cachedVelocity.y);
        //Debug.Log("Hello Cory");

        //myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, -myRigidbody.velocity.y);
    }
}
