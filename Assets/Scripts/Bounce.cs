using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    // Start is called before the first frame update
    private MoveBall script;
    public GameObject player;
    void Start()
    {
        script = player.GetComponent<MoveBall>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(){
        script.rb.AddForce(new Vector2(0,400), ForceMode2D.Impulse);
    }
}
