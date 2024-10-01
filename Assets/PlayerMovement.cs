using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor.PackageManager;
#endif
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    
    public float speed;
    public float jump;
    public bool isJumping;
    private float Move;
    public Rigidbody2D rb;
    public Collider2D col;



    
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();  
        col = GetComponent<Collider2D>();
    
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        //Jump power
        if(Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            //This is for a debug, will not affect game
            Debug.Log("jump");

        }

       
    }


    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
         {
             isJumping = false; //if player is collided with object (ground) then means Not jumping.
         }

    }

    
    public void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
}
