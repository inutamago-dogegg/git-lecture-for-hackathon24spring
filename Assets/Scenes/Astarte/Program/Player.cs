using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
public float walkSpeed = 1f;

// ここにプレイヤーのRigidbody2Dを保存します
private Rigidbody2D _rb;

void Start()
{
    // _rbにプレイヤーのRigidbody2Dの住所を保存しておく
    _rb = gameObject.GetComponent<Rigidbody2D>();
}

void Update()
{
    // varでこのフレームでのみ使える一時的な変数を宣言できます
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
        
    // ダッシュ処理
    if (Input.GetKey(KeyCode.LeftShift))
    {
         xVector *= 2f;
    }
        
    _rb.velocity = new Vector2(xVector * walkSpeed,yVector * walkSpeed);
}
}
