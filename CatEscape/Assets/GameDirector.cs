﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{

    private GameObject hpGauge; // HPゲージ

	void Start ()
    {
        hpGauge = GameObject.Find("hpGauge");
	}
	
    public void DecreaseHp()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
	}
}
