using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rigid2D;
    private Animator animator;
    private float jumpForce = 680.0f;
    private float walkForce = 30.0f;
    private float maxWalkSpeed = 2.0f;

    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // ジャンプ
        if(Input.GetKeyDown(KeyCode.Space)){
            rigid2D.AddForce(transform.up * jumpForce);
        }

        // 左右
        int key = 0;
        if(Input.GetKey(KeyCode.RightArrow)) key = 1;
        if(Input.GetKey(KeyCode.LeftArrow)) key = -1;

        // プレイヤ速度
        float speedX = Mathf.Abs(rigid2D.velocity.x);

        // スピード制限
        if(speedX < maxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }

        // 動く方向に応じて反転
        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        // プレイヤ速度に応じてアニメーション速度変更
        animator.speed = speedX / 2.0f;
    }
}
