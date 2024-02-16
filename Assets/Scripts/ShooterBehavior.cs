using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    private MoveBall playerScript;
    public GameObject player;
    public GameObject proj;
    private ProjBehavior projScript;
    public float angle = 0f;
    public Vector3 offset = new Vector3(0,0,0);
    public int reload;

    void Start()
    {
        playerScript = player.GetComponent<MoveBall>();
        projScript = proj.GetComponent<ProjBehavior>();
        reload = 120;
        
    }
    void Update()
    {
        reload--;
        transform.Rotate(Vector3.back, 180*Time.deltaTime);
    }

    void OnCollisionEnter2D(){
        if(playerScript.VSpeed >playerScript.VSpeed_min&&reload<=0){

            Shoot(angle,offset);
            reload=120;
        }
        playerScript.rb.AddForce(new Vector2(0,100), ForceMode2D.Impulse);
        playerScript.VSpeed =playerScript.VSpeed_min;
    }
    void Shoot(float facing, Vector3 offset){
        Instantiate(proj, transform.position+offset, Quaternion.Euler(0,0,facing));
    }
}
