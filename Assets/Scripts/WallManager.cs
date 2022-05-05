using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// Wallの全ての処理を管理するメソッド
/// </summary>
public class WallManager : MonoBehaviour
{
    [SerializeField] WallAnimation wallAnimation;
    private void Start()
    {
        wallAnimation.MoveWall();
    }

    private void FixedUpdate()
    {   
        
    }

}
