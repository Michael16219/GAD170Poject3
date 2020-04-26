using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    //public Rigidbody theRB;
    public float jumpForce = 5f;
    public CharacterController controller;

    private Vector3 moveDirection;
    public float gravityScale;
    // Start is called before the first frame update
    void Start()
    {
        // theRB = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        /* theRB.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, theRB.velocity.y, Input.GetAxis("Vertical") * moveSpeed);

         if(Input.GetButtonDown("Jump"))
         {
             theRB.velocity = new Vector3(theRB.velocity.x, jumpForce, theRB.velocity.z);
         }
     } */

        //moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, Input.GetAxis("Vertical") * moveSpeed);
        float yStore = moveDirection.y;
        moveDirection = (transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"));
        moveDirection = Vector3.ClampMagnitude(moveDirection, 1) * moveSpeed;
        moveDirection.y = yStore;

        if (controller.isGrounded)
        {
            moveDirection.y = 0f;
            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpForce;
            }
        }

        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
        controller.Move(moveDirection * Time.deltaTime);

        if (GetComponent<ClimbTrigger>().PlayerClimb == true)
        {
            if (Input.GetKey(KeyCode.W) == true) { this.transform.position += transform.up * Time.deltaTime * this.moveSpeed; }
        }
    }
}
