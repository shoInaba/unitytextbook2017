using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    private float speed = 0; 
    Vector2 startPos;

	void Start () {
	}
	
	void Update () {
        if(Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition; // マウス座標取得
        }
        else if(Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;      // マウス座標取得
            float swipeLength = endPos.x - this.startPos.x; // X座標の移動距離取得

            this.speed = swipeLength / 500.0f;

            GetComponent<AudioSource>().Play(); // 効果音再生
        }

        transform.Translate(this.speed, 0.0f, 0.0f);
        this.speed *= 0.98f;
	}
}