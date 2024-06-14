using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float playerspeed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input .GetKeyDown (KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right);
        }
         if(Input .GetKeyDown (KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left);
        }
         if(Input .GetKeyDown (KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up);
        }
         if(Input .GetKeyDown (KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down);
        }
       
    }
}
