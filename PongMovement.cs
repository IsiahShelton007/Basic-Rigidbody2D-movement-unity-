using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongMovement : MonoBehaviour
{
    public float speed = 5f; //Speed of the player
    public Rigidbody2D rb; //Reference to the player's rigidbody
    Vector2 movement; //Stores the player's movement

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        movement.y = Input.GetAxisRaw("Vertical"); //Get the vertical axis
    }
    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        //Move the player
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
