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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.velocity = Vector2.right * runSpeed;
            if (isTurnedLeft == true)
            {
                mySpriteRenderer.flipX = false;
            }
        }
        if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.velocity = Vector2.left * runSpeed;
            mySpriteRenderer.flipX = true;
            isTurnedLeft = true;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            myRigidbody.velocity = Vector2.up * jumpSpeed;
        }
    }
}
