using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    private GameObject player;

	void Start ()
    {
        player = GameObject.Find("player");
	}
	
	void Update ()
    {
        // フレーム毎に落下
        transform.Translate(0, -0.1f, 0);

        // 画面外でオブジェクト破棄
        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        // 当たり判定
        Vector2 p1 = transform.position; // 矢の座標
        Vector2 p2 = player.transform.position; // プレイヤー座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude; // プレイヤーと矢のベクトルを求める
        float f1 = 0.5f; // 矢半径
        float f2 = 1.0f; // プレイヤー半径

        // 衝突で破棄
        if(d < f1 + f2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
            Destroy(gameObject);
        }

	}
}
