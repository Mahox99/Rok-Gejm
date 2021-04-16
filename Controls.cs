using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public int speed = 4;
    public int sterspeed = 3;
    public double jumpSpeed = 9.5;
    public double gravity = 40.0;
    public Vector3 moveDirection = Vector3.zero;
    public float f_moveSpeed = 3.0f;
    public int goDown = 0, goUp = 0, z = 0;
  
    public float powerscore;

    private Rigidbody rb;
    public float forceMultMult = 50;

    public Joystick joystick;


    private void Start()
    {
        powerscore = 1.2f;
        z = 1 ;
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Roof")
        {
            goDown = 1;
        }
        if (other.gameObject.tag == "Floor")
            goUp = 1;
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Roof")
            goDown = 0;
        if (other.gameObject.tag == "Floor")
            goUp = 0;
    }
    
    private void Update()
    {
        if(Vechiclesystem.TheScore > 800*z)
        {
            powerscore += 0.2f;
            z++;
        }
    
        rb.AddForce(transform.up * speed * powerscore);
      
        if(joystick.Vertical >= 0.2f)
            rb.AddForce(transform.right * forceMultMult * joystick.Vertical);

        if (joystick.Vertical <= -0.2f)
            rb.AddForce(transform.right * forceMultMult *  joystick.Vertical);

        if (Input.GetButton("Down")) 
        {
            rb.AddForce(transform.right * forceMultMult * -1);
        }
        if (Input.GetButton("Up")) 
        {
            rb.AddForce(transform.right * forceMultMult);
        }

        if (goDown ==1)
            rb.AddForce(transform.right * (forceMultMult + 2) * -1);
        
        if(goUp == 1)
            rb.AddForce(transform.right * (forceMultMult + 2));
    }
}
