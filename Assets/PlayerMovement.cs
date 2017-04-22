using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private CharacterController myController;


    public float moveSpeed;
    float verticalVelocity = 0;

    public Transform headCamera;
    public float jumpSpeed;
    public float gravity;

    private void Start()
    {
        myController = gameObject.GetComponent<CharacterController>();
    }
    void FixedUpdate () {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    
        float forwardSpeed = Input.GetAxis("Horizontal") * moveSpeed;
        float sideSpeed = Input.GetAxis("Vertical") * moveSpeed;
        if (!myController.isGrounded)
        {
            verticalVelocity += -gravity * Time.deltaTime;
        }
        Vector3 speed = new Vector3(forwardSpeed, verticalVelocity, sideSpeed);

        speed = transform.rotation * speed;

        myController.Move(speed * Time.deltaTime);

    }

    public void Jump()
    {

        if (myController.isGrounded)
            verticalVelocity = jumpSpeed;

    }
}
