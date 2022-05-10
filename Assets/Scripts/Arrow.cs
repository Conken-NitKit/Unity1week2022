using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

///<summary>
///矢印の動きのクラス
///</summary>
public class Arrow : MonoBehaviour
{
    [SerializeField]
    private Image image;

    private const float FirstSize = 0.75f;
    private const float SecondSize = 2.5f;
    private const float DefaultSize = 1f;

    private float firstChangeSeconds = 0.07f;
    private float secondChangeSeconds = 0.3f;

    float disappearAlpha = 0f;
    float defaultAlpha = 255f;

    ///<summary>
    ///矢印が現れて消える
    ///</summary>
    public void AppearArrow()
    {
        this.transform.DOScale(new Vector2(FirstSize,FirstSize),firstChangeSeconds);
        image.DOFade(defaultAlpha,firstChangeSeconds).OnComplete(()=>{
            image.DOFade(disappearAlpha,secondChangeSeconds).SetEase(Ease.OutBack);
            this.transform.DOScale(new Vector2(SecondSize,SecondSize),secondChangeSeconds);
        });
        this.transform.localScale = new Vector2(DefaultSize,DefaultSize);
    }
}
