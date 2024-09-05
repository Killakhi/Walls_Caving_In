using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float jumpForce = 10f; //Gets the float for the jumps power
    public Rigidbody2D rb; //Creates a public for the object's rigidbody
    public bool isjumping;

    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody2D>(); //Gets the rigidbody
      isjumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        Jump(); //Calls the function 
    }

    public void Jump()
    {   
        //If space is pressed, this happens 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); //Adds force to the vector in a up direction
            isjumping=true;
        }
        else
        {
            isjumping = false;
        }
    }

    public bool IsJumping()
    {
        if (isjumping == false)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
