using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

/// <summary>
/// Wallの全ての処理を管理するメソッド
/// </summary>
public class WallManager : MonoBehaviour
{
    [SerializeField] WallAnimation wallAnimation;
    [SerializeField] GameObject[] randomCalledWalls;
    int wallNumber; 

    void Start()
    {
        wallAnimation.MoveWall();
        wallNumber = Random.Range(0, randomCalledWalls.Length);

    }
}
