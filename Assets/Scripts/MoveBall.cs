using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    // Start is called before the first frame update
    public float HSpeed = 10.0f;
    public float VSpeed_min = 7.5f;
    public float VSpeed_max = 25.0f;
    public float VSpeed;
    private float Acceleration = 2.5f;
    private float HInput;
    private bool VInput;


    void Start()
    {
        VSpeed = VSpeed_min;
    }

    // Update is called once per frame
    void Update()
    {
        //Input Initialization---------------------------------------------------------||
        HInput = Input.GetAxis("Horizontal");
        VInput = Input.GetKey(KeyCode.Space);

        //Horizontal Controls----------------------------------------------------------||
        transform.Translate(Vector2.right*Time.deltaTime*HSpeed*HInput);

        //Gravity Control: will not pass minimum or maximum Limits---------------------||
        if (VInput == true) 
             { if(VSpeed <= VSpeed_max) VSpeed += Acceleration*Time.deltaTime; }
        else { if(VSpeed >  VSpeed_min) VSpeed -= 2 * Acceleration*Time.deltaTime; }

        Physics2D.gravity = new Vector2(0,-VSpeed);

        //-----------------------------------------------------------------------------||
    }
}