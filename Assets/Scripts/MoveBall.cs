using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public Transform groundCheckCollider;

    public LayerMask ground;

    public float spriteRadius = 0.1f;
    private bool isGrounded = false;
    public float HSpeed = 10.0f;
    public float VSpeed_min = 20f;
    public float VSpeed_max = 60.0f;
    public float VSpeed;
    public float JSpeed = 450.0f;
    private float Acceleration = 16f;
    private float HInput;
    private bool VInput;
    private bool JInput;

    

    void Start()
    {
        VSpeed = VSpeed_min;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Check for if we are on the ground or not ------------------------------------||
        Grounded();
        //Input Initialization---------------------------------------------------------||
        HInput = Input.GetAxis("Horizontal");
        VInput = Input.GetKey(KeyCode.DownArrow);//accelerate
        JInput = Input.GetKeyDown(KeyCode.Space);//jump

        //Horizontal Controls----------------------------------------------------------||
        transform.Translate(Vector2.right*Time.deltaTime*HSpeed*HInput);

        //Drop Accelertion: will not pass minimum or maximum Limits---------------------||
        if(isGrounded == false){
            if (VInput) 
                { if(VSpeed <= VSpeed_max) VSpeed += 1f*Acceleration*Time.deltaTime; }
            else { if(VSpeed >  VSpeed_min) VSpeed -= 3*Acceleration*Time.deltaTime; }
        }else VSpeed = VSpeed_min;
        Physics2D.gravity = new Vector2(0,-VSpeed);
        //Jumping:---------------------------------------------------------------------||
        if(JInput&&isGrounded==true) {rb.AddForce(new Vector2(0,JSpeed), ForceMode2D.Impulse);}
        //-----------------------------------------------------------------------------||
    }
    void Grounded(){
        isGrounded = false;
        Collider2D[] colls = Physics2D.OverlapCircleAll(groundCheckCollider.position,spriteRadius,ground);
        if(colls.Length > 0) isGrounded = true;
    }
}