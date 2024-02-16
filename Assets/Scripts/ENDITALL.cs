using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ENDITALL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() => transform.Rotate(Vector3.back, 2);

    void OnCollisionEnter2D(){
        print("You WIN");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
