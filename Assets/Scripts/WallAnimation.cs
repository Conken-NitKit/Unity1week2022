using DG.Tweening;
using UnityEngine;

/// <summary>
/// Wallのアニメーションの役割を司るメソッド
/// </summary>
public class WallAnimation : MonoBehaviour
{

    float wallMoveSeconds = 5.0f;
    
    public int wallOpenedCount = 0; 

    public void MoveWall()
    {
        Vector3 pos = transform.position;

        float distanceCenter = 3.0f; ///壁のxまたはy座標の原点
        float wallCloseWSeconds = 3.0f; ///壁が動き始めるまでの時間

        Sequence sequence = DOTween.Sequence();//メンバ変数でSequenceのインスタンスを作成


        if (pos.x < 0)
        {
            sequence.Append
                (transform.DOLocalMove(new Vector3(-distanceCenter, 0, 0), wallMoveSeconds)
                .SetDelay(wallCloseWSeconds)
                .OnComplete(()=> {
                    wallOpenedCount++;
                    Debug.Log("Opened：" + wallOpenedCount);

                 })
                .SetEase(Ease.OutQuart))
                .SetLoops(-1, LoopType.Yoyo);
        }
        else if(pos.x > 0)
        {
            sequence.Append
               (transform.DOLocalMove(new Vector3(distanceCenter, 0, 0), wallMoveSeconds)
               .SetDelay(wallCloseWSeconds)
               .SetEase(Ease.OutQuart))
               .SetLoops(-1, LoopType.Yoyo);
        }

        else if (pos.y < 0)
        {
             
            sequence.Append
                (transform.DOLocalMove(new Vector3(0, -distanceCenter, 0), wallMoveSeconds)
                .SetDelay(wallCloseWSeconds)
                .OnComplete(() => {
                    wallOpenedCount++;
                    Debug.Log("Opened：" + wallOpenedCount);

                })
                .SetEase(Ease.OutQuart))
                .SetLoops(-1, LoopType.Yoyo);
        }
        else
        {
            sequence.Append
               (transform.DOLocalMove(new Vector3(0, distanceCenter, 0), wallMoveSeconds)
               .SetDelay(wallCloseWSeconds)
               .SetEase(Ease.OutQuart))
               .SetLoops(-1, LoopType.Yoyo);
        }
        
    }

}
