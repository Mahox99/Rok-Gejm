using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls2 : MonoBehaviour
{
    float speed = 8.0f;
    float jumpspeed = 20.5f;
    float gravity = 20.0f;
    Vector3 moveDirection = Vector3.zero;

  

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal") + 3, 1, 1);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y += jumpspeed;
            }

        }
        else
        {
            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y += jumpspeed;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;

        controller.Move(moveDirection * Time.deltaTime);
    }
}
