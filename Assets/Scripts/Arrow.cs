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

    private float firstMoveSeconds = 0.07f;
    private float secondMoveSeconds = 0.3f;

    float disappearAlpha = 0f;
    float normalAlpha = 255f;

    ///<summary>
    ///矢印が現れて消える
    ///</summary>
    public void ArrowAppear()
    {
        this.transform.DOScale(new Vector2(FirstSize,FirstSize),firstMoveSeconds);
        image.DOFade(normalAlpha,firstMoveSeconds).OnComplete(()=>{
            image.DOFade(disappearAlpha,secondMoveSeconds).SetEase(Ease.OutBack);
            this.transform.DOScale(new Vector2(SecondSize,SecondSize),secondMoveSeconds);
        });
        this.transform.localScale = new Vector2(DefaultSize,DefaultSize);
    }
}
