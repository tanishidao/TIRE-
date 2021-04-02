using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContro : MonoBehaviour
{
    [SerializeField] private Vector3 velocity;　//移動方向
    [SerializeField] private float moveSpeed = 5.0f;//　移動速度

    private void Update()
    {
        velocity = Vector3.zero;
        // WASD入力から、XZ平面(水平な地面)を移動する方向(velocity)を得ます(今回は横キーADだけ)
        //常に
        velocity.x += 5;
       
        if (Input.GetKey(KeyCode.A))
        {
            velocity.z += 1;
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity.z -= 1;
            
        }
        if (Input.GetKey(KeyCode.Space))
        {
            velocity.y += 2;
        }
        // 速度ベクトルの長さを1秒でmoveSpeedだけ進むように調整
        velocity = velocity.normalized * moveSpeed * Time.deltaTime;

        // どの方向に移動している場合
        if (velocity.magnitude > 0)
        {
            // プレイヤーの位置(transform.position)の更新
            // 移動方向ベクトル(velocity)を足し込みます
            transform.position += velocity;
        }
    }

}
