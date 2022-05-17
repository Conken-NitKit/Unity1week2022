using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

/// <summary>
/// スコアの加算を管理するクラス
/// </summary>
public class ScoreText : MonoBehaviour
{
    [SerializeField]private WallAnimation wallAnimation;
    [SerializeField]public Text scoreText;

    private void Start()
    {
       SetScore(); 
    }
    
    public void SetScore()
    {
        scoreText.text = $"回避数 {wallAnimation.wallOpenedCount}回" ;
    }    
}