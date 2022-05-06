using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// Wallのアニメーションの役割を司るメソッド
/// </summary>
public class WallAnimation : MonoBehaviour
{

    [SerializeField] float moveWallSeconds;
    
    public void MoveWall()
    {
        Vector3 pos = transform.position;


        float distanceCenter = 3.0f; ///壁のスタートするxまたはy座標から中央までの絶対値の距離
        float closeWallWSeconds = 3.0f; ///壁が動き始めるまでの時間

        
        if (pos.x < 0)
        {
            transform.DOLocalMove(new Vector3(-distanceCenter, 0, 0), moveWallSeconds)
                .SetDelay(closeWallWSeconds)
                .SetLoops(2, LoopType.Yoyo)
                .SetEase(Ease.OutQuart);

        }
        else if(pos.x > 0)
        {
            transform.DOLocalMove(new Vector3(distanceCenter, 0, 0), moveWallSeconds)
                .SetDelay(closeWallWSeconds)
                .SetLoops(2, LoopType.Yoyo)
                .SetEase(Ease.OutQuart);

        }
        else if (pos.y < 0)
        {
            transform.DOLocalMove(new Vector3(0, -distanceCenter, 0), moveWallSeconds)
                .SetDelay(closeWallWSeconds)
                .SetLoops(2, LoopType.Yoyo)
                .SetEase(Ease.OutQuart);
        }
        else
        {
            transform.DOLocalMove(new Vector3(0, distanceCenter, 0), moveWallSeconds)
                .SetDelay(closeWallWSeconds)
                .SetLoops(2, LoopType.Yoyo)
                .SetEase(Ease.OutQuart);
        }
    }



}
