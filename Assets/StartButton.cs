using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

/// <summary>
/// タイトル画面におけるボタンの動きを管理するクラス
/// </summary>
public class StartButton : MonoBehaviour
{

    [SerializeField] private Scenes scene; //ボタンを押したときシーンを遷移する
    float ScaleChangeTime = 0.5f;
    float ScaleChangeMagnification = 1.1f;
    public enum Scenes
    {
        Title,
        Main,
    }

    /// <summary>
    /// ボタンがクリックされたときボタンが一瞬拡大する
    /// </summary>
    public void OnClicked()
    {
        transform.DOScale(ScaleChangeMagnification,ScaleChangeTime).SetEase(Ease.OutElastic).OnComplete(() => SceneManager.LoadScene($"{scene}"));    
    }
    
}

