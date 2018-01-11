using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour {

    float rotSpeed = 0.0f; // 回転速度

	void Start ()
    {
	}
	
	void Update ()
    {
		// マウスが押されたら回転速度を設定
        if(Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 100;
        }

        // 回転速度分ルーレットを回転
        transform.Rotate(0, 0, this.rotSpeed);

        // ルーレット減衰
        this.rotSpeed *= 0.96f;
	}
}
