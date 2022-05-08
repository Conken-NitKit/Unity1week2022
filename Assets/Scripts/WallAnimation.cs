using DG.Tweening;
using UnityEngine;

/// <summary>
/// Wallのアニメーションの役割を司るメソッド
/// </summary>
public class WallAnimation : MonoBehaviour
{

    [SerializeField] float moveWallSeconds;
    
    [SerializeField] int openedWallCount = 0; 

    public void MoveWall()
    {
        Vector3 pos = transform.position;

        float distanceCenter = 3.0f; ///壁のxまたはy座標の原点
        float closeWallWSeconds = 3.0f; ///壁が動き始めるまでの時間

        Sequence sequence = DOTween.Sequence();//メンバ変数でSequenceのインスタンスを作成


        if (pos.x < 0)
        {
            sequence.Append
                (transform.DOLocalMove(new Vector3(-distanceCenter, 0, 0), moveWallSeconds)
                .SetDelay(closeWallWSeconds)
                .SetLoops(2, LoopType.Yoyo)
                .OnComplete(()=> {
                    openedWallCount++;
                    Debug.Log("Opened：" + openedWallCount);

                 })
                .SetEase(Ease.OutQuart))
                .SetLoops(-1);
        }
        else if(pos.x > 0)
        {
            sequence.Append
               (transform.DOLocalMove(new Vector3(distanceCenter, 0, 0), moveWallSeconds)
               .SetDelay(closeWallWSeconds)
               .SetLoops(2, LoopType.Yoyo)
               .SetEase(Ease.OutQuart))
               .SetLoops(-1);
        }

        /*else if (pos.y < 0)
        {
             sequence.Append
                (transform.DOLocalMove(new Vector3(0,-distanceCenter, 0), moveWallSeconds)
                .SetDelay(closeWallWSeconds)
                .SetLoops(2, LoopType.Yoyo)
                .OnComplete(()=> Debug.Log(openedWallCount++))
                .SetEase(Ease.OutQuart))
                .SetLoops(-1);
        }
        else
        {
            sequence.Append
                 (transform.DOLocalMove(new Vector3(0, distanceCenter, 0), moveWallSeconds)
                 .SetDelay(closeWallWSeconds)
                 .SetLoops(2, LoopType.Yoyo)
                 .SetEase(Ease.OutQuart))
                 .SetLoops(-1);
        }
        */
    }

}
