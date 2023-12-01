using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float movementSpeed = 6f;
    [SerializeField] Transform cam;
    bool isGrounded = false;

    static int maxJumps = 2;
    int jumps = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Lock player x rotation to 0 (prevent player tilt on camera tilt)
        Vector3 eulerAngles = transform.eulerAngles;
        rb.transform.rotation = Quaternion.Euler(0,eulerAngles.y, eulerAngles.z );

        //Inputs
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Camera Directions
        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;

        camForward.y = 0;
        camRight.y = 0;

        //Create relative camera direction
        Vector3 forwardRelative = verticalInput * camForward;
        Vector3 rightRelative = horizontalInput * camRight;

        Vector3 moveDir = forwardRelative + rightRelative;
        //moveDir.y = transform.position.y;

        //movement
        rb.velocity = new Vector3(moveDir.x * movementSpeed, rb.velocity.y, moveDir.z * movementSpeed);

        if (Input.GetButtonDown("Jump") && jumps > 0)
        {
            rb.velocity = new Vector3(rb.velocity.x, 6, rb.velocity.z);
            jumps--;
        }

            
            
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            isGrounded = true;
            jumps = maxJumps;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isGrounded = false;
        }
    }
}
