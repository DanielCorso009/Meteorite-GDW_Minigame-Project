using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0f,-40.0f,0);
    private float limitBottom = -20;
    private float limitTop = 20;
    void LateUpdate()
    {
        if(player.transform.position.y < transform.position.y+limitBottom)
         {
            transform.position = transform.position+offset; 
            
         }else if(player.transform.position.y > transform.position.y+limitTop){
            transform.position = transform.position-offset; 
         }
         //print((transform.position.y+limitBottom) + " " + player.transform.position.y);
    }
}
