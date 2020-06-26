using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movements : MonoBehaviour
{
    private object tf;

    // Start is called before the first frame update
    void Start()
    {
        Transform transform1 = GetComponent<Transform>();
          
    }

    // Update is called once per frame
    void Update() {
    
      Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.1f, 1.0f);
      transform.position = transform.position + horizontal * Time.deltaTime; 
    
          
    }
}
