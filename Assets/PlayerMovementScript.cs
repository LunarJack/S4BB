using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public float maxSpeed = 200f;//Replace with your max speed


    public SpriteRenderer mySpriteRenderer;
    public Rigidbody2D myRigidbody;
    public bool onGround;
    public float jumpStrength = 600;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.AddForce(Vector2.right, ForceMode2D.Impulse);
            mySpriteRenderer.flipX = false;
            Debug.Log("Moved Right");

        }
        if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.AddForce(Vector2.left, ForceMode2D.Impulse);
            mySpriteRenderer.flipX = true;
            Debug.Log("Moved Left");
        }
        if (Input.GetKeyDown(KeyCode.Space) && onGround == true)
        {
            myRigidbody.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
     
            onGround = false;
            Debug.Log("Jumped");
        }
    }
    void FixedUpdate()
    {
        if (myRigidbody.velocity.magnitude > maxSpeed)
        {
            myRigidbody.velocity = myRigidbody.velocity.normalized * maxSpeed;
        }
    }
}
