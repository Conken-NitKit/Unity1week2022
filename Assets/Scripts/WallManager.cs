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
    
    void Start()
    {
        wallAnimation.MoveWall();
  
    }
}
