﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour {

    [SerializeField]private GameObject arrowPrefab;
    private float span = 1.0f;
    private float delta = 0.0f;

	void Update () {
        delta += Time.deltaTime;
        if(delta > span){
            delta = 0;
            GameObject go = Instantiate(arrowPrefab) as GameObject;
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
            
	}
}
