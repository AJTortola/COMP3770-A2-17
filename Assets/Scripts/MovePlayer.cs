using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] 
    float speed = 10f;
    [SerializeField]
    float jumpSpeed = 5f;
    [SerializeField]
    float gravity = 9.81f;
    private Vector3 moveDirection = Vector3.zero;
    public float sensitivity = 5f;
    [SerializeField]
    int numOfAlowedDJumps = 1; 
    int DoubleJumpCounter = 0;

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        // is the controller on the ground
        if (controller.isGrounded)
        {
            
            //Feed moveDirection with input.
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            //Multiply it by speed.
            moveDirection *= speed;
            //Jumping

            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpSpeed;
                DoubleJumpCounter = 0;
            }
        }
        else
        {
            moveDirection.x = Input.GetAxis("Horizontal") * speed;
            moveDirection.z = Input.GetAxis("Vertical") * speed;

            if (Input.GetButtonDown("Jump") && DoubleJumpCounter < numOfAlowedDJumps)
            {
                moveDirection.y = jumpSpeed;
                DoubleJumpCounter++;
            }

        }

        //Applying gravity to the controller
        moveDirection.y -= gravity * Time.deltaTime;
        //Making the character move
        controller.Move(moveDirection * Time.deltaTime);
    }
}