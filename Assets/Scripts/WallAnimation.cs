using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// Wallのアニメーションの役割を司るメソッド
/// </summary>
public class WallAnimation : MonoBehaviour
{

    [SerializeField] float wallMoveTime;
    

    public void WallMove()
    {
        Transform myTransform = this.transform;
        Vector3 pos = transform.position;
        
        
        if (pos.x < 0)
        {
            transform.DOLocalMove(new Vector3(-3f, 0, 0), wallMoveTime).SetDelay(3f);
        }
        
        else if(pos.x > 0)
        {
            transform.DOLocalMove(new Vector3(3f, 0, 0), wallMoveTime).SetDelay(3f);
        }
        else if (pos.y < 0)
        {
            transform.DOLocalMove(new Vector3(0, -3f, 0), wallMoveTime).SetDelay(3f);
        }
        else
        {
            transform.DOLocalMove(new Vector3(0, 3f, 0), wallMoveTime).SetDelay(3f);
        }
    }

}
