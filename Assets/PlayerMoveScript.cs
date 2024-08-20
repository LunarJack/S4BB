using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    public SpriteRenderer mySpriteRenderer;
    public Rigidbody2D myRigidbody;
    public float runSpeed;
    public float jumpSpeed;
    public bool isTurnedLeft = false;
    public bool isInAir = false;
    public double speed = 2.0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && isInAir == false | Input.GetKey(KeyCode.RightArrow) && isInAir == false)
        {
            myRigidbody.velocity = Vector2.right * runSpeed;
            if (isTurnedLeft == true)
            {
                mySpriteRenderer.flipX = false;
            }
        }
        if (Input.GetKey(KeyCode.A) && isInAir == false | Input.GetKey(KeyCode.LeftArrow) && isInAir == false)
        {
            myRigidbody.velocity = Vector2.left * runSpeed;
            mySpriteRenderer.flipX = true;
            isTurnedLeft = true;
        }
        if (Input.GetKey(KeyCode.Space) && isInAir == false)
        {
            myRigidbody.velocity = Vector2.up * jumpSpeed;
            isInAir = true;
            
        }



    }
}