using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaa : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float walkSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     // varでこのフレームでのみ使える一時的な変数を宣言できます
      Vector2 v = new Vector2(0,0);
    
     // 入力処理
     if (Input.GetKey(KeyCode.RightArrow))
     {
         v.x += 1f;
      }
       if (Input.GetKey(KeyCode.LeftArrow))
      {
          v.x -= 1f;
      }
         if (Input.GetKey(KeyCode.UpArrow))
      {
          v.y += 1f;
      }
         if (Input.GetKey(KeyCode.DownArrow))
      {
          v.y -= 1f;
      }
        
      // ダッシュ処理
      if (Input.GetKey(KeyCode.LeftShift))
      {
           v.x *= 2f;
           v.y *= 2f;
      }
        
      _rb.velocity = v*walkSpeed;
    }
}
