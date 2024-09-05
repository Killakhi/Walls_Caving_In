using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWall : MonoBehaviour
{
    [SerializeField] float thrust = 50f;
    public Rigidbody2D rb;
    public PlayerController playerController;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (playerController.isjumping)
        {
            rb.AddForce(transform.right * -thrust);

        } else { 

            rb.velocity = Vector3.zero;
        }

    }
}
