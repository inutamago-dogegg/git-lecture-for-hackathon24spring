using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Program : MonoBehaviour
{
    // Start is called before the first frame update
    public float walkSpeed = 1f;
    public Rigidbody2D _rb;
    void Start()
    {
     _rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     var xVector = 0f;
     var yVector = 0f;
        
        // 入力処理
        if (Input.GetKey(KeyCode.RightArrow))
        {
            xVector += 1f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            xVector -= 1f;
        } 
        if (Input.GetKey(KeyCode.UpArrow))
        {
            yVector += 1f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            yVector -= 1f;
        }  

        _rb.velocity = new Vector2(xVector * walkSpeed, yVector * walkSpeed);   
    }
}
