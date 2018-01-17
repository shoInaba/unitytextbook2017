using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 左移動
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }

    // 右移動
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }
}
