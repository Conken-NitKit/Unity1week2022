using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WallAnimation : MonoBehaviour
{

    [SerializeField] float MoveTime;
    

    public void widthWallMove()
    {
        Transform myTransform = this.transform;
        Vector2 pos = transform.position;
        

        if (pos.x < 0)
        {
            transform.DOLocalMove(new Vector2(-3, 0), MoveTime);
        }
        
        else if(pos.x > 0)
        {
            transform.DOLocalMove(new Vector2(3, 0), MoveTime);
        }
        else if (pos.y < 0)
        {
            transform.DOLocalMove(new Vector2(0, -3), MoveTime);
        }
        else
        {
            transform.DOLocalMove(new Vector2(0, 3), MoveTime);
        }
    }

}
