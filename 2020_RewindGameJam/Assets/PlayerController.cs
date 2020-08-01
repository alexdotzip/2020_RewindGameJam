using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform target;
    private Rigidbody2D myRigidbody;
    private float movePlayerHorizontal;


    [SerializeField]private float moveSpeed = 5f;

    [SerializeField]private float jumpForce = 3f;

    private Vector2 movement;

    private bool isGrounded;
    private bool canDoubleJump;

    public Transform groundCheckPoint;
    public LayerMask whatIsGround;


    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayerHorizontal = Input.GetAxisRaw("Horizontal");

        //movement = new Vector2(movePlayerHorizontal, myRigidbody.velocity.y);

        //myRigidbody.velocity = movement * moveSpeed;

        myRigidbody.velocity = new Vector2(movePlayerHorizontal * moveSpeed, myRigidbody.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
        }
    }


   
    
}
