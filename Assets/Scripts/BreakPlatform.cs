using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break_Platform : MonoBehaviour
{
    // Start is called before the first frame update
    private MoveBall script;
    public GameObject player;

    public GameObject proj;
    void Start()
    {
        script = player.GetComponent<MoveBall>();
    }

    // Update is called once per frame
    void Update()
    {
        //print(proj.tag);Projectile(Clone)
    }
    void OnCollisionEnter2D(Collision2D other){
        string nameWithoutClone = other.gameObject.name.Substring(0,other.gameObject.name.Length-7);
        if(script.VSpeed >= 45){
        Destroy(gameObject); 
        script.VSpeed = script.VSpeed_min;
        script.rb.AddForce(new Vector2(0,300), ForceMode2D.Impulse);
        }else if(nameWithoutClone == proj.name){
            Destroy(gameObject);
        }
    }
}
