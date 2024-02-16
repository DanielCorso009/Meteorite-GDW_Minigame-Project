using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public float HSpeed = 40f;
    public int duration = 600;

    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(1,0,0)*HSpeed*Time.deltaTime);
        if(duration <= 0){
            Destroy(gameObject);
        }else{
            duration--;
        }
    }
    void OnCollisionEnter2D(){
        Destroy(gameObject);
    }
}
